Imports System.Drawing.Drawing2D
Imports System.IO
Imports Google.Cloud.Firestore

Public Class UcInventory
    Private db As FirestoreDb
    Private allProducts As New List(Of Dictionary(Of String, Object))
    Private isInternalUpdate As Boolean = False

    ' 🔹 Map product names to images
    Private productImages As New Dictionary(Of String, Image) From {
        {"cosi", My.Resources.Resource1.cosi},
        {"Royal Canin Hepatic Adult Wet Dog Food", My.Resources.Resource1.Royal_Canin_Hepatic_Adult_Wet_Dog_Food},
        {"Royal Canin Recovery for Dogs and Cats Canned", My.Resources.Resource1.Royal_Canin_Recovery_for_Dogs_and_Cats},
        {"Dr. Healmedix Hepatic 1.5kg Dog Dry Food", My.Resources.Resource1.Dr__Healmedix_Hepatic_1_5kg_Dog},
        {"Pedigree DENTASTIX Daily Oral Care", My.Resources.Resource1.Pedigree_DENTASTIX_Daily_oral_care},
        {"Pedigree Puppy Chicken Chunks in Gravy Wet Dog Food", My.Resources.Resource1.Pedigree_Puppy_Chicken_Chunks},
        {"Pedigree Puppy Wet Dog Food Beef Flavor in Gravy", My.Resources.Resource1.PEDIGREE_PUPPY_WET_DOG_FOOD_BEEF},
        {"Pedigree Adult Beef in Gravy Wet Dog", My.Resources.Resource1.Pedigree_Adult_Beef_in_Gravy_Wet_Dog},
        {"Special Delight Tuna and Ocean Fish", My.Resources.Resource1.Special_Delight_Tuna_and_Ocean_Fish},
        {"Special Delight Tuna and Salmon Mousse", My.Resources.Resource1.Special_Delight_Tuna_and_Salmon_Mousse},
        {"Special Delight Red Meat in Jelly", My.Resources.Resource1.Specialbeef_removebg_preview},
        {"Value Meal Dog food in Can 390g", My.Resources.Resource1.Value_Meal_Dog_food},
        {"Whiskas Junior Tuna Wet Cat Food", My.Resources.Resource1.Whiskas_Junior_Tuna_Wet_Cat_Food},
        {"Whiskas Junior Mackerel Wet Cat Food", My.Resources.Resource1.Whiskas_Junior_Mackerel_Wet_Cat_Food},
        {"Tuna Cat Food Pouch for Adult", My.Resources.Resource1.Tuna_Cat_Food_Pouch_for_Adult},
        {"SHEBA WET CAT FOOD", My.Resources.Resource1.SHEBA_WET_CAT_FOOD},
        {"Kitekat Wet Cat Food Chicken and Tuna", My.Resources.Resource1.Kitekat_Wet_Cat_Food_Chicken_and_Tuna},
        {"Kitekat Wet Cat Food Chicken and Salmon", My.Resources.Resource1.Kitekat_Wet_Cat_Food_Chicken_and_Salmon},
        {"Persian Kitten Dry Cat Food 400g", My.Resources.Resource1.Persian_Kitten_Dry_Cat_Food},
        {"Royal Canin Breed Health Nutrition Shih tzu", My.Resources.Resource1.Royal_Canin_Breed_Health_Nutrition},
        {"Nutripe Lamb and Green Tripe Pure", My.Resources.Resource1.Nutripe_Lamb_and_Green_Tripe_Pure},
        {"Nutripe Dog Food Beef And Green Tripe", My.Resources.Resource1.Nutripe_Dog_Food_Beef_And_Green_Tripe},
        {"Vitality High Energy", My.Resources.Resource1.Vitality_High_Energy},
        {"Vitality Valuemeal Dog Food Grain Free", My.Resources.Resource1.Vitality_Valuemeal_Dog_Food_Grain_Free},
        {"Charco's Beef Dog Treats", My.Resources.Resource1.Charco_s_Beef_Dog_Treats},
        {"Charco's Original Dog Treats", My.Resources.Resource1.Charco_s_Original_Dog_Treats},
        {"Petdelyte Oral Solution", My.Resources.Resource1.Petdelyte_Oral_Solution},
        {"LC-Vit Syrup Multivitamins Lysine", My.Resources.Resource1.lc_vit},
        {"Hepatosure Sorbitol Inositol Hepato Protectant", My.Resources.Resource1.HEPATOSURE_Sorbitol_Inositol},
        {"Mondex Water Soluble Powder 340g", My.Resources.Resource1.Mondex_Water_Soluble_Powder_340g},
        {"Toothpaste with Chicken Flavor", My.Resources.Resource1.Toothpaste_Chicken_Flavor},
        {"Toothpaste with Beef Flavor", My.Resources.Resource1.Toothpaste_with_Beef_Flavor},
        {"Toothpaste with Mint Flavor", My.Resources.Resource1.Toothpaste_with_Mint_Flavor},
        {"Vitality Classic", My.Resources.Resource1.Vitality_Classic},
        {"Toothpaste with Orange Flavor", My.Resources.Resource1.Toothpaste_Orange_Flavor},
        {"Cat Litter Deodorant Powder", My.Resources.Resource1.Cat_Deodorant_Powder},
        {"Royal Tail Essentials Madre de Cacao Dog Soap Tutti Fruitie", My.Resources.Resource1.Royal_Tail_Essentials_Madre_de_Tutti_Frutiepng},
        {"Royal Tail Shampoo 1Gallon/4000mL", My.Resources.Resource1.Royal_Tail_Shampoo},
        {"Royal Tail Essentials Madre de Cacao Dog Soap", My.Resources.Resource1.Royal_Tail_Essentials_Madre_de_Cacao_dog_soup},
        {"Royal Tail Sweet Talk", My.Resources.Resource1.Royal_Tail_Sweet_Talk},
        {"Royal Ear Cleanser", My.Resources.Resource1.Royal_Tail_ear_Cleanser},
        {"Furfect Soap Biosulfur+Madre de Cacao", My.Resources.Resource1.Madre_Bar_Soup},
        {"Papi Groom & Bloom 3 in 1 All Purpose Shampoo", My.Resources.Resource1.Papi_Groom},
        {"Vetspro Fipronil Spray", My.Resources.Resource1.fipronilspray},
        {"Royal Canin Hairball Care Adult Wet Cat Food", My.Resources.Resource1.Royal_Canin_Hairball_Care},
        {"Wound Spray", My.Resources.Resource1.Wound_Spray},
        {"Royal Canin Urinary Care Cat Slices in Gravy", My.Resources.Resource1.SlicesGravy},
        {"Royal Canin Renal Can Wet Food for Dogs", My.Resources.Resource1.Royal_Canin_Renal_Can_Wet_Food},
        {"Royal Canin Veterinary Gastrointestinal", My.Resources.Resource1.Royal_Canin_Veterinary_Gastrointestinal},
        {"Royal Canin Veterinary Canine Urinary Wet Dog Food", My.Resources.Resource1.Royal_Canin_Veterinary_Canine_Urinary}
    }

    ' 🔹 Fallback image if product name not found
    Private defaultImage As Image = My.Resources.Resource1.cosi

    ' 🔹 Real-time listener
    Private productsListener As FirestoreChangeListener

    ' ==========================================================
    ' 🔹 FORM LOAD
    ' ==========================================================
    Private Async Sub UcInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            db = FirestoreDb.Create("pawfessional-app")
            StyleDataGridView()
            Await LoadProductsAsync()
            LoadFilterOptions()

            ' Start real-time listener
            StartRealtimeListener()
        Catch ex As Exception
            MessageBox.Show("Error initializing Firestore: " & ex.Message, "Firestore Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ==========================================================
    ' 🔹 STYLE DATA GRID
    ' ==========================================================
    Private Sub StyleDataGridView()
        Me.BackColor = Color.FromArgb(255, 255, 200)
        With dgvInventory
            .Dock = DockStyle.Fill
            .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .EnableHeadersVisualStyles = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .GridColor = Color.FromArgb(220, 210, 255)
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 28
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 42, 68)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 215, 255)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.Font = New Font("Segoe UI", 9)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 240, 255)
            .AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowTemplate.Height = 36
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 232, 255)
        End With
    End Sub

    ' ==========================================================
    ' 🔹 LOAD PRODUCTS
    ' ==========================================================
    Private Async Function LoadProductsAsync() As Task
        Try
            Dim productsRef = db.Collection("products")
            Dim snapshot = Await productsRef.GetSnapshotAsync()

            dgvInventory.SuspendLayout()
            dgvInventory.Rows.Clear()
            allProducts.Clear()

            Dim lowStockCount As Integer = 0
            Dim outOfStockCount As Integer = 0

            For Each doc In snapshot.Documents
                Dim data = doc.ToDictionary()
                allProducts.Add(data)

                Dim count As Integer = If(data.ContainsKey("count"), Convert.ToInt32(data("count")), 0)
                If count <= 0 Then outOfStockCount += 1
                If count > 0 AndAlso count <= 5 Then lowStockCount += 1
            Next

            If outOfStockCount > 0 OrElse lowStockCount > 0 Then
                Dim msg As String = ""
                If outOfStockCount > 0 Then msg &= $"🚨 {outOfStockCount} product(s) are out of stock." & vbCrLf
                If lowStockCount > 0 Then msg &= $"⚠️ {lowStockCount} product(s) are low on stock (≤5)."
                MessageBox.Show(msg, "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ApplyFilters()
            dgvInventory.ResumeLayout()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' ==========================================================
    ' 🔹 APPLY FILTERS
    ' ==========================================================
    Private Sub ApplyFilters()
        dgvInventory.SuspendLayout()
        dgvInventory.Rows.Clear()

        Dim brandFilter As String = If(cmbBrand.SelectedIndex > 0, cmbBrand.SelectedItem.ToString(), "")
        Dim typeFilter As String = If(cmbType.SelectedIndex > 0, cmbType.SelectedItem.ToString(), "")
        Dim searchFilter As String = txtSearch.Text.Trim().ToLower()
        Dim showOnlyOutOfStock As Boolean = chkOutOfStock.Checked

        Dim filtered = allProducts.Where(Function(p)
                                             Dim matchBrand = (brandFilter = "" OrElse p("brand").ToString() = brandFilter)
                                             Dim matchType = (typeFilter = "" OrElse p("productType").ToString() = typeFilter)
                                             Dim matchSearch = (searchFilter = "" OrElse p("name").ToString().ToLower().Contains(searchFilter))
                                             Dim matchStock = (Not showOnlyOutOfStock OrElse Convert.ToInt32(p("count")) <= 0)
                                             Return matchBrand AndAlso matchType AndAlso matchSearch AndAlso matchStock
                                         End Function).ToList()

        For Each p In filtered
            Dim count As Integer = Convert.ToInt32(p("count"))
            Dim productName As String = p("name").ToString().Trim()

            ' ✅ Find matching image case-insensitively
            Dim img As Image = Nothing

            ' 🔹 If Firestore has Base64 image → use that
            If p.ContainsKey("image") AndAlso Not String.IsNullOrEmpty(p("image").ToString()) Then
                Try
                    Dim bytes = Convert.FromBase64String(p("image").ToString())
                    Using ms As New MemoryStream(bytes)
                        img = Image.FromStream(ms)
                    End Using
                Catch
                    img = defaultImage ' fallback
                End Try
            Else
                ' 🔹 Use resource only if no uploaded image exists
                Dim matchingKey = productImages.Keys.FirstOrDefault(Function(k) k.Trim().ToLower() = productName.ToLower())
                img = If(matchingKey IsNot Nothing, productImages(matchingKey), defaultImage)
            End If


            Dim rowIndex = dgvInventory.Rows.Add(img, p("productID"), productName, p("brand"), count, p("productType"))

            If count <= 0 Then
                dgvInventory.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red
            ElseIf count <= 5 Then
                dgvInventory.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Yellow
            End If
        Next

        dgvInventory.ClearSelection()
        dgvInventory.CurrentCell = Nothing
        dgvInventory.ResumeLayout()
        dgvInventory.Refresh()
    End Sub

    ' ==========================================================
    ' 🔹 FILTER EVENT HANDLERS
    ' ==========================================================
    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilters()
    End Sub

    Private Sub chkOutOfStock_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutOfStock.CheckedChanged
        ApplyFilters()
    End Sub

    ' ==========================================================
    ' 🔹 UPDATE STOCK IN FIRESTORE
    ' ==========================================================
    Private Async Sub dgvInventory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellEndEdit
        Try
            If dgvInventory.Columns(e.ColumnIndex).HeaderText <> "Stock" AndAlso dgvInventory.Columns(e.ColumnIndex).Name <> "count" Then Return

            Dim row = dgvInventory.Rows(e.RowIndex)
            Dim productId As String = row.Cells(1).Value.ToString()
            Dim newStockValue As Integer

            If Not Integer.TryParse(row.Cells(e.ColumnIndex).Value.ToString(), newStockValue) Then
                MessageBox.Show("Invalid stock value. Please enter a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Await LoadProductsAsync()
                Return
            End If

            Dim productRef = db.Collection("products").Document(productId)
            Await productRef.UpdateAsync(New Dictionary(Of String, Object) From {{"count", newStockValue}})

            If newStockValue <= 0 Then
                row.DefaultCellStyle.BackColor = Color.Red
            ElseIf newStockValue <= 5 Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If

            MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message, "Firestore Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ==========================================================
    ' 🔹 POPULATE FILTER OPTIONS
    ' ==========================================================
    Private Sub LoadFilterOptions()
        Dim brands = allProducts.Select(Function(p) p("brand").ToString()).Distinct().OrderBy(Function(b) b).ToList()
        Dim types = allProducts.Select(Function(p) p("productType").ToString()).Distinct().OrderBy(Function(t) t).ToList()

        cmbBrand.Items.Clear()
        cmbType.Items.Clear()

        cmbBrand.Items.Add("All Brands")
        cmbType.Items.Add("All Types")
        cmbBrand.Items.AddRange(brands.ToArray())
        cmbType.Items.AddRange(types.ToArray())

        cmbBrand.SelectedIndex = 0
        cmbType.SelectedIndex = 0
    End Sub

    ' ==========================================================
    ' 🔹 REAL-TIME FIRESTORE LISTENER
    ' ==========================================================
    Private Sub StartRealtimeListener()
        Try
            Dim productsRef = db.Collection("products")
            productsListener = productsRef.Listen(
                Sub(snapshot)
                    If Me.InvokeRequired Then
                        Me.Invoke(Sub() ProcessRealtimeSnapshot(snapshot))
                    Else
                        ProcessRealtimeSnapshot(snapshot)
                    End If
                End Sub)
        Catch ex As Exception
            MessageBox.Show("Error starting real-time listener: " & ex.Message, "Firestore Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ProcessRealtimeSnapshot(snapshot As QuerySnapshot)
        Try
            If isInternalUpdate Then Return

            dgvInventory.SuspendLayout()
            dgvInventory.Rows.Clear()
            allProducts.Clear()

            Dim lowStockCount As Integer = 0
            Dim outOfStockCount As Integer = 0

            For Each doc In snapshot.Documents
                Dim data = doc.ToDictionary()
                allProducts.Add(data)

                Dim count As Integer = If(data.ContainsKey("count"), Convert.ToInt32(data("count")), 0)
                If count <= 0 Then outOfStockCount += 1
                If count > 0 AndAlso count <= 5 Then lowStockCount += 1
            Next

            If outOfStockCount > 0 OrElse lowStockCount > 0 Then
                Dim msg As String = ""
                If outOfStockCount > 0 Then msg &= $"🚨 {outOfStockCount} product(s) are out of stock." & vbCrLf
                If lowStockCount > 0 Then msg &= $"⚠️ {lowStockCount} product(s) are low on stock (≤5)."
                MessageBox.Show(msg, "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ApplyFilters()
            dgvInventory.ResumeLayout()
            dgvInventory.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error processing real-time snapshot: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ==========================================================
    ' 🔹 STOP LISTENER WHEN FORM DISPOSED
    ' ==========================================================
    ' Stop the listener safely when the form/control is closing
    Private Sub UcInventory_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed
        Try
            If productsListener IsNot Nothing Then
                Try
                    ' StopAsync can throw if already stopped
                    productsListener.StopAsync() ' fire-and-forget, don't await
                Catch ex As InvalidOperationException
                    ' Ignore
                End Try
                productsListener = Nothing
            End If
        Catch ex As Exception
            ' Log or ignore
        End Try
    End Sub

    Private Async Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        ' Open AddProductForm FIRST
        Using addForm As New AddProductForm
            If addForm.ShowDialog() = DialogResult.OK Then

                isInternalUpdate = True

                ' Stop listener AFTER the form closes
                If productsListener IsNot Nothing Then
                    Try
                        Await productsListener.StopAsync()
                    Catch
                    End Try
                    productsListener = Nothing

                End If



                isInternalUpdate = False

                ' Restart listener
                StartRealtimeListener()
            End If
        End Using
    End Sub

    Private Async Sub btnEditProduct_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product first.")
            Return
        End If

        ' Product ID is in column index 1
        Dim id = dgvInventory.SelectedRows(0).Cells(1).Value.ToString

        Dim editForm As New AddProductForm With {
            .IsEdit = True,
            .ProductID = id
        }

        If editForm.ShowDialog = DialogResult.OK Then

            isInternalUpdate = True

            isInternalUpdate = False
        End If
    End Sub

    Private Async Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product first.")
            Return
        End If

        ' Product ID is in column index 1
        Dim productID As String = dgvInventory.SelectedRows(0).Cells(1).Value.ToString()

        ' Confirm delete
        If MessageBox.Show("Are you sure you want to delete this product?",
                           "Delete Product",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try

            Dim db As FirestoreDb = FirestoreDb.Create("pawfessional-app")
            Dim docRef = db.Collection("products").Document(productID)

            Await docRef.DeleteAsync()

            MessageBox.Show("Product deleted successfully!")

            ' Refresh table


        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message)
        End Try
    End Sub

End Class
