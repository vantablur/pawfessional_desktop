Imports Google.Cloud.Firestore
Imports System.Windows.Forms
Imports System.Threading.Tasks

Public Class FirestoreHelperClass
    Public Shared db As FirestoreDb
    Private Shared isInitializing As Boolean = False

    ''' <summary>
    ''' Initializes Firestore asynchronously. Call this once at app startup.
    ''' </summary>
    Public Shared Async Function InitializeFirestoreAsync() As Task
        ' Prevent multiple simultaneous initializations
        If db IsNot Nothing OrElse isInitializing Then Return
        isInitializing = True

        Try
            ' Set the path to your service account JSON
            Dim jsonPath As String = IO.Path.Combine(Application.StartupPath, "serviceAccount.json")
            If Not IO.File.Exists(jsonPath) Then
                MessageBox.Show("Firestore credential file not found: " & jsonPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                isInitializing = False
                Return
            End If

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", jsonPath)

            ' Initialize Firestore asynchronously
            db = Await Task.Run(Function() FirestoreDb.Create("pawfessional-app")) ' <-- your project ID

        Catch ex As Exception
            MessageBox.Show("Failed to initialize Firestore: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            isInitializing = False
        End Try
    End Function
End Class
