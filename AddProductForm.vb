Imports Google.Cloud.Firestore
Imports System.IO
Imports System.Drawing.Imaging

Public Class AddProductForm

    Public Property IsEdit As Boolean = False
    Public Property ProductID As String = ""

    Private base64Image As String = ""

    ' -----------------------------
    ' FORM SHOWN EVENT (ASYNC)
    ' -----------------------------
    Private Async Sub AddProductForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If IsEdit Then
                txtProductID.Enabled = True
                Await LoadExistingProduct()   ' 🔹 Load Firestore data
            Else
                txtProductID.Enabled = True
                txtProductID.Text = ""
                ClearImage()
            End If
        Catch ex As Exception
            MessageBox.Show("Error initializing form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------
    ' CLEAR IMAGE METHOD
    ' -----------------------------
    Private Sub ClearImage()
        If picProduct.Image IsNot Nothing Then
            picProduct.Image.Dispose()
            picProduct.Image = Nothing
        End If
        base64Image = ""
    End Sub

    ' -----------------------------
    ' LOAD EXISTING PRODUCT
    ' -----------------------------
    Private Async Function LoadExistingProduct() As Task
        Try
            Dim db = FirestoreDb.Create("pawfessional-app")
            Dim docRef = db.Collection("products").Document(ProductID)
            Dim snap = Await docRef.GetSnapshotAsync()

            If Not snap.Exists Then
                MessageBox.Show("Product not found!")
                Return
            End If

            txtProductID.Text = snap.GetValue(Of Object)("productID").ToString()
            txtName.Text = snap.GetValue(Of Object)("name").ToString()
            txtBrand.Text = snap.GetValue(Of Object)("brand").ToString()
            txtStock.Text = snap.GetValue(Of Object)("count").ToString()
            txtProductType.Text = snap.GetValue(Of Object)("productType").ToString()

            ' 🔹 Load Base64 image
            If snap.ContainsField("image") Then
                base64Image = snap.GetValue(Of Object)("image").ToString()
                If Not String.IsNullOrEmpty(base64Image) Then
                    Dim bytes = Convert.FromBase64String(base64Image)
                    Using ms As New MemoryStream(bytes)
                        picProduct.Image = Image.FromStream(ms)
                    End Using
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading product: " & ex.Message)
        End Try
    End Function

    ' -----------------------------
    ' SAVE TO FIRESTORE
    ' -----------------------------
    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim db = FirestoreDb.Create("pawfessional-app")

            Dim productData As New Dictionary(Of String, Object) From {
                {"productID", txtProductID.Text},
                {"name", txtName.Text},
                {"brand", txtBrand.Text},
                {"count", Integer.Parse(txtStock.Text)},
                {"productType", txtProductType.Text},
                {"image", base64Image}
            }

            Dim docRef = db.Collection("products").Document(txtProductID.Text)
            Await docRef.SetAsync(productData, SetOptions.Overwrite)

            MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving product: " & ex.Message)
        End Try
    End Sub

    ' -----------------------------
    ' CANCEL BUTTON
    ' -----------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' -----------------------------
    ' IMAGE UPLOAD
    ' -----------------------------
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Try
            Using dlg As New OpenFileDialog()
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
                dlg.Title = "Select a product image"

                ' Show dialog **with AddProductForm as owner**
                If dlg.ShowDialog() = DialogResult.OK Then

                    ' Dispose previous image
                    If picProduct.Image IsNot Nothing Then picProduct.Image.Dispose()

                    ' Load the image safely
                    Using fs As New FileStream(dlg.FileName, FileMode.Open, FileAccess.Read)
                        picProduct.Image = Image.FromStream(fs)
                    End Using

                    ' Convert to Base64 for Firestore
                    Using ms As New MemoryStream()
                        picProduct.Image.Save(ms, Imaging.ImageFormat.Png)
                        base64Image = Convert.ToBase64String(ms.ToArray())
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try
    End Sub

End Class
