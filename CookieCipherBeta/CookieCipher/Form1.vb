Public Class Form1
    Private Function cipher(ByVal encrypt As Boolean, ByVal s As String)
        Dim r As String = Nothing
        If (encrypt) Then
            For Each c As Char In s
                If (c = "a") Then r &= "h"
                If (c = "b") Then r &= "l"
                If (Not c = "a" And Not c = "b") Then r &= c
            Next
        Else
            For Each c As Char In s
                If (c = "h") Then r &= "a"
                If (c = "l") Then r &= "b"
                If (Not c = "h" And Not c = "l") Then r &= c
            Next
        End If
        Return r
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = cipher(True, TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = cipher(False, TextBox2.Text)
    End Sub
End Class
