Imports FontAwesome.Sharp

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class client
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Button3 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Data = New DataGridView()
        edit = New DataGridViewButtonColumn()
        modifier = New DataGridViewButtonColumn()
        supprimer = New DataGridViewButtonColumn()
        IconButton11 = New IconButton()
        TextBox5 = New TextBox()
        Panel1 = New Panel()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        CType(Data, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(60, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 5
        Label3.Text = "adresse_cli"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(60, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 6
        Label4.Text = "nom_cli"' 
        ' TextBox2
        ' 
        TextBox2.Cursor = Cursors.Cross
        TextBox2.Location = New Point(163, 143)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.Cross
        TextBox1.Location = New Point(163, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 7
        TextBox1.Text = "2"' 
        ' Button1
        ' 
        Button1.Location = New Point(527, 547)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Cursor = Cursors.Cross
        TextBox4.Location = New Point(163, 293)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Cursor = Cursors.Cross
        TextBox3.Location = New Point(163, 208)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(815, 547)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "afficher"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(57, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 4
        Label2.Text = "prenom-cli"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(57, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 3
        Label1.Text = "numero_cli"' 
        ' Data
        ' 
        Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data.Columns.AddRange(New DataGridViewColumn() {edit, modifier, supprimer})
        Data.Cursor = Cursors.NoMove2D
        Data.Location = New Point(379, 346)
        Data.Name = "Data"
        Data.RowTemplate.Height = 25
        Data.Size = New Size(858, 150)
        Data.TabIndex = 11
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
        ' IconButton11
        ' 
        IconButton11.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        IconButton11.FlatAppearance.BorderSize = 0
        IconButton11.FlatStyle = FlatStyle.Flat
        IconButton11.IconChar = IconChar.MagnifyingGlass
        IconButton11.IconColor = Color.Gainsboro
        IconButton11.IconFont = IconFont.Solid
        IconButton11.IconSize = 32
        IconButton11.Location = New Point(930, 278)
        IconButton11.Name = "IconButton11"
        IconButton11.Size = New Size(110, 33)
        IconButton11.TabIndex = 12
        IconButton11.Text = "Search"
        IconButton11.TextAlign = ContentAlignment.MiddleLeft
        IconButton11.TextImageRelation = TextImageRelation.TextBeforeImage
        IconButton11.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(1046, 278)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(175, 23)
        TextBox5.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(IconButton11)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Data)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1338, 744)
        Panel1.TabIndex = 16
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' client
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1345, 745)
        Controls.Add(Panel1)
        Name = "client"
        Text = "client"
        CType(Data, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Data As DataGridView
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents modifier As DataGridViewButtonColumn
    Friend WithEvents supprimer As DataGridViewButtonColumn
    Friend WithEvents IconButton11 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
