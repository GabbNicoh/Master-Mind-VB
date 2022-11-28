Public Class Form1
    Dim ctr As Integer = 0 ' checks how many text box has a number, if ctr % 4 == 0 then first line is removed, second line activated
    Dim A(3), num As Integer ' creates 4 blank arrays
    Dim correctcnt As Integer = 4
    Dim lotnum() As Label = {Label8, Label9, Label10, Label11}

    ' TO FIX
    ' - scoring
    ' - bug with multiple numbers
    ' - Winning and losing
    ' - polish
    ' - design

    Public Sub textBoxLoop()
        Dim row As Integer
        Dim col As Integer
        Dim txtbox(,) As TextBox = {{TextBox1, TextBox2, TextBox3, TextBox4},
                                    {TextBox5, TextBox6, TextBox7, TextBox8},
                                    {TextBox9, TextBox10, TextBox11, TextBox12},
                                    {TextBox13, TextBox14, TextBox15, TextBox16},
                                    {TextBox17, TextBox18, TextBox19, TextBox20},
                                    {TextBox21, TextBox22, TextBox23, TextBox24}}

        ' disables all except active row
        If ctr = 0 Then
            For x = 1 To 5
                For y = 0 To 3
                    txtbox(x, y).Enabled = False
                Next
            Next
        End If

        For col = 0 To 3
            If ctr = 4 Then
                row = 0
                txtbox(row, col).Enabled = False
                If Not txtbox(row, col).Text = A(col) Then
                    correctcnt -= 1
                End If
                Label1.Text = correctcnt
                For x = 0 To 3
                    txtbox(row + 1, col).Enabled = True
                Next
            ElseIf ctr = 8 Then
                row = 1
                txtbox(row, col).Enabled = False
                If Not txtbox(row, col).Text = A(col) Then
                    correctcnt -= 1
                End If
                Label2.Text = correctcnt
                For x = 0 To 3
                    txtbox(row + 1, col).Enabled = True
                Next
            ElseIf ctr = 12 Then
                row = 2
                txtbox(row, col).Enabled = False
                If Not txtbox(row, col).Text = A(col) Then
                    correctcnt -= 1
                End If
                Label3.Text = correctcnt
                For x = 0 To 3
                    txtbox(row + 1, col).Enabled = True
                Next
            ElseIf ctr = 16 Then
                row = 3
                txtbox(row, col).Enabled = False
                If Not txtbox(row, col).Text = A(col) Then
                    correctcnt -= 1
                End If
                Label4.Text = correctcnt
                For x = 0 To 3
                    txtbox(row + 1, col).Enabled = True
                Next
            ElseIf ctr = 20 Then
                row = 4
                txtbox(row, col).Enabled = False
                If Not txtbox(row, col).Text = A(col) Then
                    correctcnt -= 1
                End If
                Label5.Text = correctcnt
                For x = 0 To 3
                    txtbox(row + 1, col).Enabled = True
                Next
            ElseIf ctr = 24 Then
                row = 5
                txtbox(row, col).Enabled = False
                If Not txtbox(row, col).Text = A(col) Then
                    correctcnt -= 1
                End If
                Label6.Text = correctcnt
            End If

            If col = 3 Then
                correctcnt = 4
            End If
        Next col
        ' DEBUG
        Label7.Text = Str(ctr)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Randomize()

        For i = 0 To 3 ' counts to 4
            A(i) = -1
        Next i

        For j = 0 To 3
            If A(j) = -1 Then
                num = Int(Rnd() * 6) + 1
                While A.Contains(num)
                    num = Int(Rnd() * 6) + 1
                End While
            End If
            A(j) = num
        Next j

        Label8.Text = A(0)
        Label9.Text = A(1)
        Label10.Text = A(2)
        Label11.Text = A(3)

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        Button5.Enabled = False
        textBoxLoop()
    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False
        TextBox14.Enabled = False
        TextBox15.Enabled = False
        TextBox16.Enabled = False
        TextBox17.Enabled = False
        TextBox18.Enabled = False
        TextBox19.Enabled = False
        TextBox20.Enabled = False
        TextBox21.Enabled = False
        TextBox22.Enabled = False
        TextBox23.Enabled = False
        TextBox24.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ctr += 1
        textBoxLoop()
        ' TextBox1.Enabled = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged
        ctr += 1
        textBoxLoop()
    End Sub

End Class
