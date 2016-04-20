Public Class Form1
    Private Function cipher(ByVal encrypt As Boolean, ByVal s As String)
        Dim r As String = Nothing
        If (encrypt) Then
            For Each c As Char In s
                If (c = "a") Then r &= "8"
                If (c = "b") Then r &= "4"
                If (c = "c") Then r &= "6"
                If (c = "d") Then r &= "_"
                If (c = "e") Then r &= "2"
                If (c = "f") Then r &= "u"
                If (c = "g") Then r &= "x"
                If (c = "h") Then r &= "="
                If (c = "i") Then r &= "-"
                If (c = "j") Then r &= "h"
                If (c = "k") Then r &= "l"
                If (c = "l") Then r &= "m"
                If (c = "m") Then r &= "p"
                If (c = "n") Then r &= "t"
                If (c = "o") Then r &= "c"
                If (c = "p") Then r &= "#"
                If (c = "q") Then r &= "'"
                If (c = "r") Then r &= "*"
                If (c = "s") Then r &= "&"
                If (c = "t") Then r &= "{"
                If (c = "u") Then r &= ","
                If (c = "v") Then r &= ";"
                If (c = "w") Then r &= "+"
                If (c = "x") Then r &= "}"
                If (c = "y") Then r &= "~"
                If (c = "z") Then r &= "s"
                If (c = " ") Then r &= "0"
                If (Not c = "a" And Not c = "b" And Not c = "c" And Not c = "d" And Not c = "e" And Not c = "f" And Not c = "g" And Not c = "h" And Not c = "i" And Not c = "j" And Not c = "k" And Not c = "l" And Not c = "m" And Not c = "n" And Not c = "o" And Not c = "p" And Not c = "q" And Not c = "r" And Not c = "s" And Not c = "t" And Not c = "u" And Not c = "v" And Not c = "w" And Not c = "x" And Not c = "y" And Not c = "z" And Not c = "c") Then r &= c
            Next
        Else
            For Each c As Char In s
                If (c = "8") Then r &= "a"
                If (c = "4") Then r &= "b"
                If (c = "6") Then r &= "c"
                If (c = "_") Then r &= "d"
                If (c = "2") Then r &= "e"
                If (c = "u") Then r &= "f"
                If (c = "x") Then r &= "g"
                If (c = "=") Then r &= "h"
                If (c = "-") Then r &= "i"
                If (c = "h") Then r &= "j"
                If (c = "l") Then r &= "k"
                If (c = "m") Then r &= "l"
                If (c = "p") Then r &= "m"
                If (c = "t") Then r &= "n"
                If (c = "c") Then r &= "o"
                If (c = "#") Then r &= "p"
                If (c = "'") Then r &= "q"
                If (c = "*") Then r &= "r"
                If (c = "&") Then r &= "s"
                If (c = "{") Then r &= "t"
                If (c = ",") Then r &= "u"
                If (c = ";") Then r &= "v"
                If (c = "+") Then r &= "w"
                If (c = "}") Then r &= "x"
                If (c = "~") Then r &= "y"
                If (c = "s") Then r &= "z"
                If (c = "0") Then r &= " "
                If (Not c = "8" And Not c = "4" And Not c = "6" And Not c = "_" And Not c = "2" And Not c = "u" And Not c = "x" And Not c = "=" And Not c = "-" And Not c = "h" And Not c = "l" And Not c = "m" And Not c = "p" And Not c = "t" And Not c = "c" And Not c = "#" And Not c = "'" And Not c = "*" And Not c = "&" And Not c = "{" And Not c = "," And Not c = ";" And Not c = "}" And Not c = "~" And Not c = "0") Then r &= c
            Next
        End If
        Return r
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = cipher(True, TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TextBox2.Text = cipher(False, TextBox2.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = cipher(False, TextBox2.Text)
    End Sub
End Class
