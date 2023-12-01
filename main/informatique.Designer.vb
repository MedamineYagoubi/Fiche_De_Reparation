<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informatique
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
        Dateee = New DateTimePicker()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Data = New DataGridView()
        edit = New DataGridViewButtonColumn()
        modifier = New DataGridViewButtonColumn()
        supprimer = New DataGridViewButtonColumn()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TextBox5 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        CType(Data, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 15)
        Label1.TabIndex = 0
        Label1.Text = "numero_serie"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 1
        Label2.Text = "marque"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 2
        Label3.Text = "date_ach"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 3
        Label4.Text = "prix_ach"' 
        ' Dateee
        ' 
        Dateee.Location = New Point(118, 123)
        Dateee.Name = "Dateee"
        Dateee.Size = New Size(222, 23)
        Dateee.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(124, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(124, 78)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(118, 174)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(222, 23)
        TextBox3.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(151, 503)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 23)
        Button1.TabIndex = 10
        Button1.Text = "ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(355, 503)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 23)
        Button2.TabIndex = 11
        Button2.Text = "afficher"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Data
        ' 
        Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data.Columns.AddRange(New DataGridViewColumn() {edit, modifier, supprimer})
        Data.Location = New Point(79, 319)
        Data.Name = "Data"
        Data.RowTemplate.Height = 25
        Data.Size = New Size(929, 134)
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
        ' IconButton1
        ' 
        IconButton1.BackColor = SystemColors.MenuBar
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchLocation
        IconButton1.IconColor = Color.Gainsboro
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(411, 225)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(112, 44)
        IconButton1.TabIndex = 13
        IconButton1.Text = "chercher"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(551, 237)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 15)
        Label5.TabIndex = 15
        Label5.Text = "numero_cli"' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(136, 212)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(204, 23)
        TextBox4.TabIndex = 16
        ' 
        ' informatique
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1246, 691)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox5)
        Controls.Add(IconButton1)
        Controls.Add(Data)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Dateee)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "informatique"
        Text = "informatique"
        CType(Data, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Dateee As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Data As DataGridView
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents modifier As DataGridViewButtonColumn
    Friend WithEvents supprimer As DataGridViewButtonColumn
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
