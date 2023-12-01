<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panne
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Data = New DataGridView()
        edit = New DataGridViewButtonColumn()
        modifier = New DataGridViewButtonColumn()
        supprimer = New DataGridViewButtonColumn()
        TextBox5 = New TextBox()
        Dateee = New DateTimePicker()
        Label4 = New Label()
        CType(Data, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 0
        Label1.Text = "numero_panne"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 1
        Label2.Text = "nom_panne"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 2
        Label3.Text = "description"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(146, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(146, 81)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(146, 123)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 5
        ' 
        ' IconButton1
        ' 
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        IconButton1.IconColor = Color.Gainsboro
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(326, 123)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(91, 36)
        IconButton1.TabIndex = 6
        IconButton1.Text = "chercher"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(423, 136)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(87, 185)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(215, 185)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "afficher"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Data
        ' 
        Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data.Columns.AddRange(New DataGridViewColumn() {edit, modifier, supprimer})
        Data.Location = New Point(120, 325)
        Data.Name = "Data"
        Data.RowTemplate.Height = 25
        Data.Size = New Size(697, 150)
        Data.TabIndex = 10
        ' 
        ' edit
        ' 
        edit.HeaderText = "edit"
        edit.Name = "edit"
        edit.Text = "edit"
        edit.ToolTipText = "edit"
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
        ' TextBox5
        ' 
        TextBox5.Location = New Point(180, 223)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 11
        ' 
        ' Dateee
        ' 
        Dateee.Location = New Point(90, 156)
        Dateee.Name = "Dateee"
        Dateee.Size = New Size(200, 23)
        Dateee.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(91, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 13
        Label4.Text = "numero_serie"' 
        ' panne
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1133, 699)
        Controls.Add(Label4)
        Controls.Add(Dateee)
        Controls.Add(TextBox5)
        Controls.Add(Data)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(IconButton1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "panne"
        Text = "panne"
        CType(Data, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Data As DataGridView
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents modifier As DataGridViewButtonColumn
    Friend WithEvents supprimer As DataGridViewButtonColumn
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Dateee As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
