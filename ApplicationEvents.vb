Imports System.IO

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        ' This event is raised when the application starts.
        ' You can add code here to initialize resources or settings before the main form is shown.
        Private Sub MyApplication_Startup(sender As Object, e As EventArgs) Handles Me.Startup
            Dim source As String = Path.Combine(AppContext.BaseDirectory, "UserDataBase.mdb")
            Dim destinationFolder As String = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "TheNumbers"
            )
            Dim destination As String = Path.Combine(destinationFolder, "UserDataBase.mdb")
            Try
                If Not File.Exists(destination) Then
                    Directory.CreateDirectory(destinationFolder)
                    File.Copy(source, destination)
                End If
            Catch ex As Exception
                MessageBox.Show("Error copying database: " & ex.Message)
            End Try
        End Sub
        ' This event is raised after all application forms are closed.
        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            ' Cleanup code here
        End Sub
        ' This event is raised if the application encounters an unhandled exception.
        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            ' Handle the exception here
            e.ExitApplication = True ' Optionally exit the application
        End Sub
    End Class
End Namespace
