
Imports FontAwesome.Sharp
Imports Microsoft.Win32

Public Class Form1
    Private currentbtn As IconButton
    Private leftborderbtn As Panel
    Private currentbtnchildform As Form
    Dim len As Integer
    Dim counter As Integer
    Dim txt As String

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        leftborderbtn = New Panel()
        leftborderbtn.Size = New Size(7, 60)
        Pa.Controls.Add(leftborderbtn)
    End Sub
    'methods 
    Private Sub activatenbutton(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
            disablebutton()
            'button
            currentbtn = CType(senderbtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(37, 36, 81)

            currentbtn.ForeColor = customcolor
            currentbtn.IconColor = customcolor
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'lef border
            leftborderbtn.BackColor = customcolor
            leftborderbtn.Location = New Point(0, currentbtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()
            'current from icon 
            IconPictureBox1.IconChar = currentbtn.IconChar
            IconPictureBox1.IconColor = customcolor





        End If

    End Sub
    Private Sub disablebutton()
        If currentbtn IsNot Nothing Then
            currentbtn.BackColor = Color.FromArgb(0, 0, 64)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub
    Private Sub openchiledform(childform As Form)
        If currentbtnchildform IsNot Nothing Then
            currentbtnchildform.Close()
        End If
        currentbtnchildform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        Panel1.Controls.Add(childform)
        Panel1.Tag = childform
        childform.BringToFront()
        childform.Show()
        Label1.Text = childform.Text

    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        activatenbutton(sender, rgbcolor.colors1)
        openchiledform(New client)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        activatenbutton(sender, rgbcolor.colors2)
        openchiledform(New informatique)


    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        activatenbutton(sender, rgbcolor.colors3)
        openchiledform(New panne)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        activatenbutton(sender, rgbcolor.colors4)
        openchiledform(New reparationn)
    End Sub


    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        activatenbutton(sender, rgbcolor.colors5)
        openchiledform(New piece_changer)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Pa_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub IconButton2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        counter = 0
        len = Label2.Text.Length
        txt = Label2.Text
        Label2.Text = ""
        Timer1.Start()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        If counter > len Then
            counter = 0
            Label2.Text = ""
        Else
            Label2.Text = txt.Substring(0, counter)
        End If
        If Label2.ForeColor = Color.Yellow Then
            Label2.ForeColor = Color.White
        Else
            Label2.ForeColor = Color.Yellow

        End If
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = Date.Now
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label3.Text = Date.Now
    End Sub


End Class