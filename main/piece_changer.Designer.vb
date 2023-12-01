<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class piece_changer
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Data = New DataGridView()
        edit = New DataGridViewButtonColumn()
        modifier = New DataGridViewButtonColumn()
        supprimer = New DataGridViewButtonColumn()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TextBox3 = New TextBox()
        CType(Data, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 0
        Label1.Text = "numero_piece"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 1
        Label2.Text = "description"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(163, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(163, 100)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(93, 152)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(231, 152)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "afficher"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Data
        ' 
        Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data.Columns.AddRange(New DataGridViewColumn() {edit, modifier, supprimer})
        Data.Location = New Point(63, 243)
        Data.Name = "Data"
        Data.RowTemplate.Height = 25
        Data.Size = New Size(507, 150)
        Data.TabIndex = 6
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
        modifier.HeaderText = "modifer"
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
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        IconButton1.IconColor = Color.Gainsboro
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(409, 136)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(109, 37)
        IconButton1.TabIndex = 7
        IconButton1.Text = "chercher"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(539, 152)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        ' 
        ' piece_changer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1121, 450)
        Controls.Add(TextBox3)
        Controls.Add(IconButton1)
        Controls.Add(Data)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "piece_changer"
        Text = "piece_changer"
        CType(Data, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Data As DataGridView
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents modifier As DataGridViewButtonColumn
    Friend WithEvents supprimer As DataGridViewButtonColumn
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox3 As TextBox
End Class
