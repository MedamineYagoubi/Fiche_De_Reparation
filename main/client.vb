

Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows
Imports FontAwesome.Sharp

Public Class client
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim numero_cli As Integer = TextBox1.Text
        Dim nom As String = TextBox2.Text
        Dim prenon As String = TextBox3.Text
        Dim adresse As String = TextBox4.Text



        Dim query As String = "insert into client values (@numero_cli,@nom,@prenon,@adresse)"
        Using cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@numero_cli", numero_cli)
                cmd.Parameters.AddWithValue("@nom", nom)
                cmd.Parameters.AddWithValue("@prenon", prenon)
                cmd.Parameters.AddWithValue("@adresse", adresse)

                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                MessageBox.Show("inserer avec sucucees")
            End Using
        End Using

    End Sub

    Private Sub Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data.CellClick

        Try
            Dim ro As Integer = e.RowIndex

            If Data.Columns(e.ColumnIndex).Name = "edit" Then
                TextBox1.Text = Data.Rows(ro).Cells(3).Value
                TextBox2.Text = Data.Rows(ro).Cells(4).Value
                TextBox3.Text = Data.Rows(ro).Cells(5).Value
                TextBox4.Text = Data.Rows(ro).Cells(6).Value

            End If

            If Data.Columns(e.ColumnIndex).Name = "modifier" Then


                If MsgBox("vouler vous modifier", MsgBoxStyle.YesNoCancel, "modifier") = MsgBoxResult.Yes Then
                End If




                ' Définir la chaîne de connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"

                ' Définir la requête SQL pour modifier l'enregistrement
                Dim query As String = "UPDATE client  SET nom = @nom, prenon = @prenon, adresse=@adresse WHERE numero_cli = @numero_cli"

                ' Créer une connexion à la base de données
                Using cn As New SqlConnection(connectionString)
                    ' Créer une commande SQL pour exécuter la requête
                    Using cmd As New SqlCommand(query, cn)
                        ' Ajouter les paramètres à la commande SQL
                        cmd.Parameters.AddWithValue("@numero_cli", TextBox1.Text)
                        cmd.Parameters.AddWithValue("@nom", TextBox2.Text)
                        cmd.Parameters.AddWithValue("@prenon", TextBox3.Text)
                        cmd.Parameters.AddWithValue("@adresse", TextBox4.Text)



                        ' Ouvrir la connexion à la base de données
                        cn.Open()

                        ' Exécuter la commande SQL pour modifier l'enregistrement
                        cmd.ExecuteNonQuery()

                        ' Fermer la connexion à la base de données
                        cn.Close()
                        MessageBox.Show("modifier avec sucucees")
                        Data.Rows(ro).Cells(3).Value = TextBox1.Text
                        Data.Rows(ro).Cells(4).Value = TextBox2.Text
                        Data.Rows(ro).Cells(5).Value = TextBox3.Text
                        Data.Rows(ro).Cells(6).Value = TextBox4.Text

                    End Using
                End Using



            End If


            If Data.Columns(e.ColumnIndex).Name = "supprimer" Then
                If MsgBox("vouler vous supprimer", MsgBoxStyle.YesNoCancel, "supprimer") = MsgBoxResult.Yes Then
                End If
                ' Définir la chaîne de connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"

                ' Définir la requête SQL pour modifier l'enregistrement
                Dim query As String = " DELETE client  WHERE numero_cli = @numero_cli"

                ' Créer une connexion à la base de données
                Using cn As New SqlConnection(connectionString)
                    ' Créer une commande SQL pour exécuter la requête
                    Using cmd As New SqlCommand(query, cn)
                        ' Ajouter les paramètres à la commande SQL
                        cmd.Parameters.AddWithValue("@numero_cli", TextBox1.Text)



                        ' Ouvrir la connexion à la base de données
                        cn.Open()

                        ' Exécuter la commande SQL pour modifier l'enregistrement
                        cmd.ExecuteNonQuery()

                        ' Fermer la connexion à la base de données
                        cn.Close()
                        MessageBox.Show("supprimer avec sucucees")
                        Data.Rows.RemoveAt(Data.CurrentRow.Index)

                    End Using
                End Using



            End If

        Catch ex As Exception




        End Try

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectionString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"
        Dim query As String = "SELECT * FROM client"

        Dim connection As New SqlConnection(connectionString)
        Dim dataAdapter As New SqlDataAdapter(query, connection)
        Dim dataSet As New DataSet()

        connection.Open()
        dataAdapter.Fill(dataSet, "TableData")
        connection.Close()

        Data.DataSource = dataSet.Tables("TableData")




    End Sub

    Private Sub Data_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton11_Click(sender As Object, e As EventArgs) Handles IconButton11.Click
        IconButton11.FlatAppearance.BorderSize = 0
        IconButton11.FlatStyle = FlatStyle.Flat
        IconButton11.ForeColor = Color.White
        IconButton11.IconChar = FontAwesome.Sharp.IconChar.Search
        IconButton11.IconColor = Color.Gainsboro
        IconButton11.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton11.IconSize = 32
        IconButton11.ImageAlign = ContentAlignment.MiddleLeft

        IconButton11.Name = "IconButton1"
        IconButton11.Padding = New Padding(10, 0, 20, 0)

        IconButton11.TabIndex = 4
        IconButton11.Text = "Search"
        IconButton11.TextAlign = ContentAlignment.MiddleLeft
        IconButton11.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton11.UseVisualStyleBackColor = True
        'Définir la chaîne de connexion à la base de données SQL Server
        Dim connString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"

        'Définir la requête SQL pour la recherche dans la table Customers
        Dim query As String = "SELECT * FROM client WHERE numero_cli=@numero_cli"

        'Créer un objet SqlConnection pour se connecter à la base de données
        Using connection As New SqlConnection(connString)
            'Créer un objet SqlCommand pour exécuter la requête SQL
            Using command As New SqlCommand(query, connection)
                'Définir la valeur du paramètre @numero_clis avec le texte saisi dans le TextBox txtLastName
                command.Parameters.AddWithValue("@numero_cli", TextBox5.Text)

                'Créer un objet SqlDataAdapter pour remplir un objet DataTable avec les résultats de la requête SQL
                Dim adapter As New SqlDataAdapter(command)

                'Créer un objet DataTable pour stocker les résultats de la requête SQL
                Dim dt As New DataTable()

                'Remplir l'objet DataTable avec les résultats de la requête SQL
                adapter.Fill(dt)

                'Afficher les résultats dans le DataGridView dgvCustomers
                Data.DataSource = dt

            End Using
        End Using
    End Sub

    Private Sub client_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "le numero_cli doit etre numérique ")


        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If Not IsNumeric(Me.TextBox5.Text) Then
            ErrorProvider2.SetError(Me.TextBox5, "le numero_cli a chercher doit etre numérique ")




        End If
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Data_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles Data.CellContentClick

    End Sub


End Class