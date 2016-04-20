Public Class Form1
    Private Function cipher(ByVal encrypt As Boolean, ByVal s As String)
        Dim r As String = Nothing
        If (encrypt) Then
            For Each c As Char In s
                If (c = "a") Then r &= "nutella"
                If (c = "b") Then r &= "mrnoodles"
                If (c = "c") Then r &= "coffee"
                If (c = "d") Then r &= "strawberry"
                If (c = "e") Then r &= "ultra"
                If (c = "f") Then r &= "atomic"
                If (c = "g") Then r &= "fork"
                If (c = "b") Then r &= "pen"
                If (c = "i") Then r &= "-"
                If (c = "j") Then r &= "hostipal"
                If (c = "k") Then r &= "lid"
                If (c = "l") Then r &= "mat"
                If (c = "m") Then r &= "police"
                If (c = "n") Then r &= "spork"
                If (c = "o") Then r &= "cherry"
                If (c = "p") Then r &= "dog"
                If (c = "q") Then r &= "chips"
                If (c = "r") Then r &= "food"
                If (c = "s") Then r &= "trust"
                If (c = "t") Then r &= "yes"
                If (c = "u") Then r &= "head"
                If (c = "v") Then r &= "call"
                If (c = "w") Then r &= "no"
                If (c = "x") Then r &= "life"
                If (c = "y") Then r &= "bored"
                If (c = "z") Then r &= "whatever"
                If (c = " ") Then r &= "_"
                If (Not c = "a" And Not c = "b" And Not c = "c" And Not c = "d" And Not c = "e" And Not c = "f" And Not c = "g" And Not c = "h" And Not c = "i" And Not c = "j" And Not c = "k" And Not c = "l" And Not c = "m" And Not c = "n" And Not c = "o" And Not c = "p" And Not c = "q" And Not c = "r" And Not c = "s" And Not c = "t" And Not c = "u" And Not c = "v" And Not c = "w" And Not c = "x" And Not c = "y" And Not c = "z" And Not c = "c") Then r &= c
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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TextBox2.Text = cipher(False, TextBox2.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
