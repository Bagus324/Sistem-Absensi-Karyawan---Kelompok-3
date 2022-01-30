Public Class warning
    Public WarningInt = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAbsensi.absensi.closing()
        Me.Close()
    End Sub
End Class