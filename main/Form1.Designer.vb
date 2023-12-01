<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Pa = New Panel()
        PictureBox1 = New PictureBox()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        IconButton5 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Panel1 = New Panel()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        Pa.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Pa
        ' 
        Pa.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Pa.Controls.Add(PictureBox1)
        Pa.Controls.Add(IconButton6)
        Pa.Controls.Add(IconButton5)
        Pa.Controls.Add(IconButton4)
        Pa.Controls.Add(IconButton3)
        Pa.Controls.Add(IconButton2)
        Pa.Controls.Add(IconButton1)
        Pa.Dock = DockStyle.Left
        Pa.Location = New Point(0, 0)
        Pa.Name = "Pa"
        Pa.Size = New Size(255, 824)
        Pa.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.loogo
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(252, 238)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' IconButton6
        ' 
        IconButton6.FlatAppearance.BorderSize = 0
        IconButton6.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton6.IconColor = Color.Black
        IconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton6.Location = New Point(12, 723)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(111, 38)
        IconButton6.TabIndex = 0
        IconButton6.Text = "IconButton6"
        IconButton6.UseVisualStyleBackColor = True
        ' 
        ' IconButton5
        ' 
        IconButton5.FlatAppearance.BorderSize = 0
        IconButton5.FlatStyle = FlatStyle.Flat
        IconButton5.ForeColor = Color.White
        IconButton5.IconChar = FontAwesome.Sharp.IconChar.Server
        IconButton5.IconColor = Color.Gainsboro
        IconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton5.IconSize = 32
        IconButton5.ImageAlign = ContentAlignment.MiddleLeft
        IconButton5.Location = New Point(3, 617)
        IconButton5.Name = "IconButton5"
        IconButton5.Padding = New Padding(10, 0, 20, 0)
        IconButton5.Size = New Size(252, 100)
        IconButton5.TabIndex = 4
        IconButton5.Text = "piece changer"
        IconButton5.TextAlign = ContentAlignment.MiddleLeft
        IconButton5.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton5.UseVisualStyleBackColor = True
        ' 
        ' IconButton4
        ' 
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.ForeColor = Color.White
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.Screwdriver
        IconButton4.IconColor = Color.Gainsboro
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton4.IconSize = 32
        IconButton4.ImageAlign = ContentAlignment.MiddleLeft
        IconButton4.Location = New Point(3, 522)
        IconButton4.Name = "IconButton4"
        IconButton4.Padding = New Padding(10, 0, 20, 0)
        IconButton4.Size = New Size(252, 97)
        IconButton4.TabIndex = 3
        IconButton4.Text = "reparation"
        IconButton4.TextAlign = ContentAlignment.MiddleLeft
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = True
        ' 
        ' IconButton3
        ' 
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.ForeColor = Color.White
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.BugSlash
        IconButton3.IconColor = Color.Gainsboro
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton3.IconSize = 32
        IconButton3.ImageAlign = ContentAlignment.MiddleLeft
        IconButton3.Location = New Point(3, 425)
        IconButton3.Name = "IconButton3"
        IconButton3.Padding = New Padding(10, 0, 20, 0)
        IconButton3.Size = New Size(252, 96)
        IconButton3.TabIndex = 2
        IconButton3.Text = "panne"
        IconButton3.TextAlign = ContentAlignment.MiddleLeft
        IconButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton3.UseVisualStyleBackColor = True
        ' 
        ' IconButton2
        ' 
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.ForeColor = Color.White
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.LaptopCode
        IconButton2.IconColor = Color.Gainsboro
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton2.IconSize = 32
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(0, 338)
        IconButton2.Name = "IconButton2"
        IconButton2.Padding = New Padding(10, 0, 20, 0)
        IconButton2.Size = New Size(258, 93)
        IconButton2.TabIndex = 1
        IconButton2.Text = "informatique"
        IconButton2.TextAlign = ContentAlignment.MiddleLeft
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.User
        IconButton1.IconColor = Color.Gainsboro
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton1.IconSize = 32
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(0, 247)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(10, 0, 20, 0)
        IconButton1.Size = New Size(255, 97)
        IconButton1.TabIndex = 0
        IconButton1.Text = "client"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(IconPictureBox1)
        Panel2.Location = New Point(252, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1800, 111)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(781, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Label3"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Popup
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(436, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 15)
        Label2.TabIndex = 0
        Label2.Text = "projet vb.net: fiche de reparation "
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(73, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 1
        Label1.Text = "Home "' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        IconPictureBox1.ForeColor = Color.Purple
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home
        IconPictureBox1.IconColor = Color.Purple
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.Location = New Point(35, 40)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(32, 32)
        IconPictureBox1.TabIndex = 0
        IconPictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.BlueViolet
        Panel1.Location = New Point(255, 108)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1700, 1300)
        Panel1.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' Timer3
        ' 
        Timer3.Enabled = True
        Timer3.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1355, 824)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Pa)
        Name = "Form1"
        Pa.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Pa As Panel
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer3 As Timer
End Class
