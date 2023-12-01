<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reparationn
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Date1 = New DateTimePicker()
        Date2 = New DateTimePicker()
        button1 = New Button()
        Button2 = New Button()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TextBox3 = New TextBox()
        Data = New DataGridView()
        edit = New DataGridViewButtonColumn()
        modifier = New DataGridViewButtonColumn()
        supprimer = New DataGridViewButtonColumn()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Panel1 = New Panel()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Button3 = New Button()
        CType(Data, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "numero_rep"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 1
        Label2.Text = "date_d_rep"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(72, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 2
        Label3.Text = "description_rep"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(78, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 3
        Label4.Text = "date_fin_rep"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(204, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(204, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Date1
        ' 
        Date1.Location = New Point(201, 82)
        Date1.Name = "Date1"
        Date1.Size = New Size(200, 23)
        Date1.TabIndex = 6
        ' 
        ' Date2
        ' 
        Date2.Location = New Point(201, 202)
        Date2.Name = "Date2"
        Date2.Size = New Size(200, 23)
        Date2.TabIndex = 7
        ' 
        ' button1
        ' 
        button1.Location = New Point(176, 312)
        button1.Name = "button1"
        button1.Size = New Size(75, 23)
        button1.TabIndex = 8
        button1.Text = "ajouter"
        button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(271, 312)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "afficher"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        IconButton1.IconColor = Color.Gainsboro
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(386, 287)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(122, 39)
        IconButton1.TabIndex = 10
        IconButton1.Text = "chercher"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(538, 303)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 11
        ' 
        ' Data
        ' 
        Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data.Columns.AddRange(New DataGridViewColumn() {edit, modifier, supprimer})
        Data.Location = New Point(72, 472)
        Data.Name = "Data"
        Data.RowTemplate.Height = 25
        Data.Size = New Size(733, 150)
        Data.TabIndex = 12
        ' 
        ' edit
        ' 
        edit.HeaderText = "edit"
        edit.Name = "edit"
        edit.Text = "edit"
        edit.UseColumnTextForButtonValue = True
        ' 
        ' modifier
        ' 
        modifier.HeaderText = "modifier"
        modifier.Name = "modifier"
        modifier.Text = "modifier"
        modifier.UseColumnTextForButtonValue = True
        ' 
        ' supprimer
        ' 
        supprimer.HeaderText = "supprimer"
        supprimer.Name = "supprimer"
        supprimer.Text = "supprimer"
        supprimer.UseColumnTextForButtonValue = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(78, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 15)
        Label5.TabIndex = 13
        Label5.Text = "numero_piece"' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(199, 250)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 14
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Cursor = Cursors.NoMoveVert
        Panel1.Location = New Point(850, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(376, 220)
        Panel1.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(122, 135)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(141, 23)
        TextBox6.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(120, 61)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(143, 23)
        TextBox5.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(33, 138)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 15)
        Label8.TabIndex = 2
        Label8.Text = "numero_rep"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 58)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 15)
        Label7.TabIndex = 1
        Label7.Text = "numero_panne"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Location = New Point(121, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 17)
        Label6.TabIndex = 0
        Label6.Text = "zone de fiche de repation"' 
        ' Button3
        ' 
        Button3.Location = New Point(914, 258)
        Button3.Name = "Button3"
        Button3.Size = New Size(199, 23)
        Button3.TabIndex = 16
        Button3.Text = "ajouter dons fiche"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' reparationn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 730)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(Data)
        Controls.Add(TextBox3)
        Controls.Add(IconButton1)
        Controls.Add(Button2)
        Controls.Add(button1)
        Controls.Add(Date2)
        Controls.Add(Date1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "reparationn"
        Text = "reparationn"
        CType(Data, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Date1 As DateTimePicker
    Friend WithEvents Date2 As DateTimePicker
    Friend WithEvents button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Data As DataGridView
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents modifier As DataGridViewButtonColumn
    Friend WithEvents supprimer As DataGridViewButtonColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
End Class
