Public Class Form2
    Dim a As Double
    Dim b As Double
    Dim tutup As String
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        a = TextBox2.Text
        b = TextBox3.Text

        If a = 1 Then
            If b = 2 Then
                'Kilometer ke Hektometer'
                TextBox4.Text = Val(TextBox1.Text) * 10
            ElseIf b = 3 Then
                'Kilometer ke Dekameter'
                TextBox4.Text = Val(TextBox1.Text) * 100
            ElseIf b = 4 Then
                'Kilometer ke Meter'
                TextBox4.Text = Val(TextBox1.Text) * 1000
            ElseIf b = 5 Then
                'Kilometer ke Desimeter'
                TextBox4.Text = Val(TextBox1.Text) * 10000
            ElseIf b = 6 Then
                'Kilometer ke Centimeter'
                TextBox4.Text = Val(TextBox1.Text) * 100000
            ElseIf b = 7 Then
                'Kilometer ke Milimeter'
                TextBox4.Text = Val(TextBox1.Text) * 1000000
            End If

        ElseIf a = 2 Then
            If b = 1 Then
                'Hektometer ke Kilometer'
                TextBox4.Text = Val(TextBox1.Text) / 10
            ElseIf b = 3 Then
                'Hektometer ke Dekameter'
                TextBox4.Text = Val(TextBox1.Text) * 10
            ElseIf b = 4 Then
                'Hektometer ke Meter'
                TextBox4.Text = Val(TextBox1.Text) * 100
            ElseIf b = 5 Then
                'Hektometer ke Desimeter'
                TextBox4.Text = Val(TextBox1.Text) * 1000
            ElseIf b = 6 Then
                'Hektometer ke Centimeter'
                TextBox4.Text = Val(TextBox1.Text) * 10000
            ElseIf b = 7 Then
                'Hektometer ke Milimeter'
                TextBox4.Text = Val(TextBox1.Text) * 100000
            End If

        ElseIf a = 3 Then
            If b = 1 Then
                'Dekameter ke Kilometer'
                TextBox4.Text = Val(TextBox1.Text) / 100
            ElseIf b = 2 Then
                'Dekameter ke Hektometer'
                TextBox4.Text = Val(TextBox1.Text) / 10
            ElseIf b = 4 Then
                'Dekameter ke Meter'
                TextBox4.Text = Val(TextBox1.Text) * 10
            ElseIf b = 5 Then
                'Dekameter ke Desimeter'
                TextBox4.Text = Val(TextBox1.Text) * 100
            ElseIf b = 6 Then
                'Dekameter ke Centimeter'
                TextBox4.Text = Val(TextBox1.Text) * 1000
            ElseIf b = 7 Then
                'Dekameter ke Milimeter'
                TextBox4.Text = Val(TextBox1.Text) * 10000
            End If

        ElseIf a = 4 Then
            If b = 1 Then
                'Meter ke Kilometer'
                TextBox4.Text = Val(TextBox1.Text) / 1000
            ElseIf b = 2 Then
                'Meter ke Hektometer'
                TextBox4.Text = Val(TextBox1.Text) / 100
            ElseIf b = 3 Then
                'Meter ke Dekameter'
                TextBox4.Text = Val(TextBox1.Text) / 10
            ElseIf b = 5 Then
                'Meter ke Desimeter'
                TextBox4.Text = Val(TextBox1.Text) * 10
            ElseIf b = 6 Then
                'Meter ke Centimeter'
                TextBox4.Text = Val(TextBox1.Text) * 100
            ElseIf b = 7 Then
                'Meter ke Milimeter'
                TextBox4.Text = Val(TextBox1.Text) * 1000
            End If

        ElseIf a = 5 Then
            If b = 1 Then
                'Desimeter ke Kilometer'
                TextBox4.Text = Val(TextBox1.Text) / 10000
            ElseIf b = 2 Then
                'Desimeter ke Hektometer'
                TextBox4.Text = Val(TextBox1.Text) / 1000
            ElseIf b = 3 Then
                'Desimeter ke Dekameter'
                TextBox4.Text = Val(TextBox1.Text) / 100
            ElseIf b = 4 Then
                'Desimeter ke Meter'
                TextBox4.Text = Val(TextBox1.Text) / 10
            ElseIf b = 6 Then
                'Desimeter ke Centimeter'
                TextBox4.Text = Val(TextBox1.Text) * 10
            ElseIf b = 7 Then
                'Desimeter ke Milimeter'
                TextBox4.Text = Val(TextBox1.Text) * 100
            End If

        ElseIf a = 6 Then
            If b = 1 Then
                'Centimeter ke Kilometer'
                TextBox4.Text = Val(TextBox1.Text) / 100000
            ElseIf b = 2 Then
                'Centimeter ke Hektometer'
                TextBox4.Text = Val(TextBox1.Text) / 10000
            ElseIf b = 3 Then
                'Centimeter ke Dekameter'
                TextBox4.Text = Val(TextBox1.Text) / 1000
            ElseIf b = 4 Then
                'Centimeter ke Meter'
                TextBox4.Text = Val(TextBox1.Text) / 100
            ElseIf b = 5 Then
                'Centimeter ke Desimeter'
                TextBox4.Text = Val(TextBox1.Text) / 10
            ElseIf b = 7 Then
                'Centimeter ke Milimeter'
                TextBox4.Text = Val(TextBox1.Text) * 10
            End If

        ElseIf a = 7 Then
            If b = 1 Then
                'Milimeter ke Kilometer'
                TextBox4.Text = Val(TextBox1.Text) / 1000000
            ElseIf b = 2 Then
                'Milimeter ke Hektometer'
                TextBox4.Text = Val(TextBox1.Text) / 100000
            ElseIf b = 3 Then
                'Milimeter ke Dekameter'
                TextBox4.Text = Val(TextBox1.Text) / 10000
            ElseIf b = 4 Then
                'Milimeter ke Meter'
                TextBox4.Text = Val(TextBox1.Text) / 1000
            ElseIf b = 5 Then
                'Milimeter ke Desimeter'
                TextBox4.Text = Val(TextBox1.Text) / 100
            ElseIf b = 6 Then
                'Milimeter ke Centimeter'
                TextBox4.Text = Val(TextBox1.Text) / 10
            End If
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        tutup = MessageBox.Show("Apakah anda ingin keluar ?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub
End Class
