Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Integer
        For f = 0 To 255
            ComboBox1.Items.Add(f)
            ComboBox2.Items.Add(f)
            ComboBox3.Items.Add(f)
        Next
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        Dim a As Integer
        For a = 0 To 25
            ComboBox4.Items.Add(a)

        Next
        ComboBox4.SelectedIndex = 0
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If RadioButton1.Checked = True Then
            Width = 640
            Height = 480
        Else
            If RadioButton2.Checked = True Then
                Width = 800
                Height = 600
            Else
                If RadioButton3.Checked = True Then
                    Width = 1024
                    Height = 768
                End If
            End If
        End If


        Text = ""
        If CheckBox1.Checked = True Then
            Text = Text + "(camisas)"
        End If
        If CheckBox2.Checked = True Then
            Text = Text + "(Sueter)"
        End If
        If CheckBox3.Checked = True Then
            Text = Text + "(Polo)"
        End If

        Text = ""
        If CheckBox5.Checked = True Then
            Text = Text + "(Chica)"
        End If
        If CheckBox6.Checked = True Then
            Text = Text + "(Mediana)"
        End If
        If CheckBox7.Checked = True Then
            Text = Text + "(Grande)"
        End If

        Dim rojo As Integer = ComboBox1.Text
        Dim verde As Integer = ComboBox2.Text
        Dim azul As Integer = ComboBox3.Text
        BackColor = Color.FromArgb(rojo, verde, azul)

        Dim puntadas As Integer = ComboBox4.Text

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
