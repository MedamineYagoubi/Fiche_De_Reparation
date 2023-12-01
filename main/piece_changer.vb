


Imports FontAwesome.Sharp
Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports System.Data.Common
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows


Public Class piece_changer






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim numero_piece As Integer = TextBox1.Text

        Dim description As String = TextBox2.Text





        Dim query As String = "insert into piece_changer values (@numero_piece,@description)"
        Using cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@numero_piece", numero_piece)
                cmd.Parameters.AddWithValue("@description", description)

                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""


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


            End If

            If Data.Columns(e.ColumnIndex).Name = "modifier" Then


                If Global.Microsoft.VisualBasic.Interaction.MsgBox("vouler vous modifier", Global.Microsoft.VisualBasic.MsgBoxStyle.YesNoCancel, "modifier") = Global.Microsoft.VisualBasic.MsgBoxResult.Yes Then
                End If




                ' Définir la chaîne de connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"

                ' Définir la requête SQL pour modifier l'enregistrement
                Dim query As String = "UPDATE piece_changer SET  description=@description WHERE numero_piece= @numero_piece"

                ' Créer une connexion à la base de données
                Using cn As New SqlConnection(connectionString)
                    ' Créer une commande SQL pour exécuter la requête
                    Using cmd As New SqlCommand(query, cn)
                        ' Ajouter les paramètres à la commande SQL
                        cmd.Parameters.AddWithValue("@numero_piece", TextBox1.Text)

                        cmd.Parameters.AddWithValue("@description", TextBox2.Text)




                        ' Ouvrir la connexion à la base de données
                        cn.Open()

                        ' Exécuter la commande SQL pour modifier l'enregistrement
                        cmd.ExecuteNonQuery()

                        ' Fermer la connexion à la base de données
                        cn.Close()
                        MessageBox.Show("modifier avec sucucees")
                        Data.Rows(ro).Cells(3).Value = TextBox1.Text
                        Data.Rows(ro).Cells(4).Value = TextBox2.Text


                    End Using
                End Using



            End If


            If Data.Columns(e.ColumnIndex).Name = "supprimer" Then
                If Global.Microsoft.VisualBasic.Interaction.MsgBox("vouler vous supprimer", Global.Microsoft.VisualBasic.MsgBoxStyle.YesNoCancel, "supprimer") = Global.Microsoft.VisualBasic.MsgBoxResult.Yes Then
                End If
                ' Définir la chaîne de connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"

                ' Définir la requête SQL pour modifier l'enregistrement
                Dim query As String = " DELETE piece_changer WHERE numero_piece = @numero_piece"

                ' Créer une connexion à la base de données
                Using cn As New SqlConnection(connectionString)
                    ' Créer une commande SQL pour exécuter la requête
                    Using cmd As New SqlCommand(query, cn)
                        ' Ajouter les paramètres à la commande SQL
                        cmd.Parameters.AddWithValue("@numero_piece", TextBox1.Text)



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



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"
        Dim query As String = "SELECT * FROM piece_changer"

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

    Private Sub IconButton11_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Search
        IconButton1.IconColor = Color.Gainsboro
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconButton1.IconSize = 32
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft

        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(10, 0, 20, 0)
        IconButton1.TabIndex = 4
        IconButton1.Text = "Search"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = True
        'Définir la chaîne de connexion à la base de données SQL Server
        Dim connString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"

        'Définir la requête SQL pour la recherche dans la table Customers
        Dim query As String = "SELECT * FROM piece_changer WHERE numero_piece=@numero_piece"

        'Créer un objet SqlConnection pour se connecter à la base de données
        Using connection As New SqlConnection(connString)
            'Créer un objet SqlCommand pour exécuter la requête SQL
            Using command As New SqlCommand(query, connection)
                'Définir la valeur du paramètre @numero_clis avec le texte saisi dans le TextBox txtLastName
                command.Parameters.AddWithValue("@numero_piece", TextBox3.Text)

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





End Class

