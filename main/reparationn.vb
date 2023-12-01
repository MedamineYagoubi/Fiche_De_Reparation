Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports FontAwesome.Sharp
Imports System.Data.Common
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows

Public Class reparationn







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click


        Dim numero_rep As Integer = TextBox1.Text
        Dim Date_rep As Date = Date1.Value
        Dim description_p As String = TextBox2.Text
        Dim Datef_p As Date = Date2.Value
        Dim numero_piece As Integer = TextBox4.Text




        Dim query As String = "insert into repartion values (@numero_rep,@Date_rep,@description_p,@datef_p,@numero_piece )"
        Using cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@numero_rep", numero_rep)
                cmd.Parameters.AddWithValue("@Date_rep", Date_rep)
                cmd.Parameters.AddWithValue("@description_p", description_p)
                cmd.Parameters.AddWithValue("@datef_p", Datef_p)
                cmd.Parameters.AddWithValue("@numero_piece", numero_piece)

                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""


                MessageBox.Show("inserer avec sucucees")
            End Using
        End Using

    End Sub

    Private Sub Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data.CellClick

        Try
            Dim ro As Integer = e.RowIndex

            If Data.Columns(e.ColumnIndex).Name = "edit" Then
                TextBox1.Text = Data.Rows(ro).Cells(3).Value
                Date1.Value = Data.Rows(ro).Cells(4).Value
                TextBox2.Text = Data.Rows(ro).Cells(5).Value
                Date2.Value = Data.Rows(ro).Cells(6).Value
                TextBox4.Text = Data.Rows(ro).Cells(7).Value




            End If

            If Data.Columns(e.ColumnIndex).Name = "modifier" Then


                If Global.Microsoft.VisualBasic.Interaction.MsgBox("vouler vous modifier", Global.Microsoft.VisualBasic.MsgBoxStyle.YesNoCancel, "modifier") = Global.Microsoft.VisualBasic.MsgBoxResult.Yes Then
                End If




                ' Définir la chaîne de connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"

                ' Définir la requête SQL pour modifier l'enregistrement
                Dim query As String = "UPDATE repartion SET Date_rep=@Date_rep , description_p=@description_p, datef_p=@datef_p WHERE numero_rep=@numero_rep"

                ' Créer une connexion à la base de données
                Using cn As New SqlConnection(connectionString)
                    ' Créer une commande SQL pour exécuter la requête
                    Using cmd As New SqlCommand(query, cn)
                        ' Ajouter les paramètres à la commande SQL
                        cmd.Parameters.AddWithValue("@numero_rep", TextBox1.Text)
                        cmd.Parameters.AddWithValue("@Date_rep", Date1.Value)
                        cmd.Parameters.AddWithValue("@description_p", TextBox2.Text)
                        cmd.Parameters.AddWithValue("@datef_p", Date2.Value)
                        cmd.Parameters.AddWithValue("@numero_piece", TextBox4.Text)




                        ' Ouvrir la connexion à la base de données
                        cn.Open()

                        ' Exécuter la commande SQL pour modifier l'enregistrement
                        cmd.ExecuteNonQuery()

                        ' Fermer la connexion à la base de données
                        cn.Close()
                        MessageBox.Show("modifier avec sucucees")
                        Data.Rows(ro).Cells(3).Value = TextBox1.Text
                        Data.Rows(ro).Cells(4).Value = Date1.Value
                        Data.Rows(ro).Cells(5).Value = TextBox2.Text
                        Data.Rows(ro).Cells(6).Value = Date2.Value
                        Data.Rows(ro).Cells(7).Value = TextBox4.Text


                    End Using
                End Using



            End If


            If Data.Columns(e.ColumnIndex).Name = "supprimer" Then
                If Global.Microsoft.VisualBasic.Interaction.MsgBox("vouler vous supprimer", Global.Microsoft.VisualBasic.MsgBoxStyle.YesNoCancel, "supprimer") = Global.Microsoft.VisualBasic.MsgBoxResult.Yes Then
                End If
                ' Définir la chaîne de connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True"

                ' Définir la requête SQL pour modifier l'enregistrement
                Dim query As String = " DELETE repartion WHERE numero_rep=@numero_rep"

                ' Créer une connexion à la base de données
                Using cn As New SqlConnection(connectionString)
                    ' Créer une commande SQL pour exécuter la requête
                    Using cmd As New SqlCommand(query, cn)
                        ' Ajouter les paramètres à la commande SQL
                        cmd.Parameters.AddWithValue("@numero_rep", TextBox1.Text)



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
        Dim query As String = "SELECT * FROM repartion"

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
        Dim query As String = "SELECT * FROM repartion WHERE numero_rep=@numero_rep"

        'Créer un objet SqlConnection pour se connecter à la base de données
        Using connection As New SqlConnection(connString)
            'Créer un objet SqlCommand pour exécuter la requête SQL
            Using command As New SqlCommand(query, connection)
                'Définir la valeur du paramètre @numero_clis avec le texte saisi dans le TextBox txtLastName
                command.Parameters.AddWithValue("@numero_rep", TextBox3.Text)

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numero_panne As Integer = TextBox5.Text
        Dim numero_rep As Integer = TextBox6.Text


        Dim query As String = "insert into fiche values (@numero_panne,@numero_rep)"
        Using cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-NFTKGO5\SQLEXPRESS;Initial Catalog=vb;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@numero_panne", numero_panne)
                cmd.Parameters.AddWithValue("@numero_rep", numero_rep)


                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                TextBox5.Text = ""
                TextBox6.Text = ""



                MessageBox.Show("inserer avec sucucees ")
            End Using
        End Using


    End Sub
End Class