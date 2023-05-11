Public Class Form1
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label_Fogot_Logins_Click(sender As Object, e As EventArgs) Handles Label_Fogot_Logins.Click

    End Sub

    Private Sub Label_Fogot_Logins_MouseHover(sender As Object, e As EventArgs) Handles Label_Fogot_Logins.MouseHover
        Label_Fogot_Logins.ForeColor = Color.LightGray

        Me.Label_Fogot_Logins.Font = New Font(Label_Fogot_Logins.Font, FontStyle.Underline)
    End Sub

    Private Sub Label_Fogot_Logins_MouseLeave(sender As Object, e As EventArgs) Handles Label_Fogot_Logins.MouseLeave
        Me.Label_Fogot_Logins.Font = New Font(Label_Fogot_Logins.Font, FontStyle.Regular)
        Label_Fogot_Logins.ForeColor = Color.Black
    End Sub

    Private Sub Label_Register_Click(sender As Object, e As EventArgs) Handles Label_Register.Click

    End Sub

    Private Sub Label_Register_MouseHover(sender As Object, e As EventArgs) Handles Label_Register.MouseHover
        Label_Register.ForeColor = Color.LightGray

        Me.Label_Register.Font = New Font(Label_Register.Font, FontStyle.Underline)
    End Sub

    Private Sub Label_Register_MouseLeave(sender As Object, e As EventArgs) Handles Label_Register.MouseLeave
        Label_Register.ForeColor = Color.Black

        Me.Label_Register.Font = New Font(Label_Register.Font, FontStyle.Regular)
    End Sub

    Private Sub Guna2TextBox2_IconRightClick(sender As Object, e As EventArgs) Handles Guna2TextBox2.IconRightClick
        If Guna2TextBox2.UseSystemPasswordChar Then
            Exit Sub
            Guna2TextBox2.UseSystemPasswordChar = False
            ''Guna2TextBox2.IconRight = Resources.
            Guna2TextBox2.PasswordChar = ""
        Else
            Exit Sub
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class
