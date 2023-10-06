Imports System.Data.OleDb

Public Class Classe
    Dim projetPath As String = Application.StartupPath
    Dim dataBasePath As String = projetPath & "\BD\bd.accdb"
    Private chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dataBasePath & ";Persist Security Info=False"
    Private selectedId As Integer = 0

    Private Sub recuperation_data() ''recuperation data dans la base de donnée''
        Tableau_classe.Rows.Clear()

        Try
            Dim maconnexion As New OleDbConnection(Me.chemin) ''creation de la connexion''
            maconnexion.Open()
            Dim requete As String = "SELECT * FROM Classe" ''recupération des données dans la table inscription''
            Dim cmd As New OleDbCommand(requete, maconnexion)
            Dim mes_donnes As OleDbDataReader
            mes_donnes = cmd.ExecuteReader()

            Do While mes_donnes.Read() ''read permet de lire ligne par ligne les infos du tableau''
                Tableau_classe.Rows.Add(mes_donnes.Item("nomClasse"), mes_donnes.Item("idClasse"))
            Loop
            maconnexion.Close()

        Catch ex As Exception
            MessageBox.Show("ERROR")


        End Try

    End Sub

    Sub supprimer_data(ID As Integer) ''procedure de suppresion''
        Dim maconnection As New OleDbConnection(Me.chemin)
        maconnection.Open()
        Dim requete As String = "DELETE FROM Classe WHERE idClasse = " & ID
        Dim cmd As New OleDbCommand(requete, maconnection)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Suppression effectuée avec Succes")
        Else
            MessageBox.Show("ERREUR , echec de l'operation")
        End If
        maconnection.Close()

    End Sub

    Private Sub Btn_ajout_classe_Click(sender As Object, e As EventArgs) Handles Btn_ajout_classe.Click
        Dim valeur_classe As String = classe_champs.Text

        Tableau_classe.Rows.Add(valeur_classe)

        Try
            Dim maconnexion As New OleDbConnection(Me.chemin)
            maconnexion.Open()

            If selectedId = 0 Then
                ' Créer un nouvel enregistrement
                Dim requete As String = "INSERT INTO Classe(nomClasse) VALUES('" & valeur_classe & "')"
                Dim cmd As New OleDbCommand(requete, maconnexion)
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Insertion réussie")
                End If
            Else
                ' Mettre à jour l'enregistrement existant
                Dim requete As String = "UPDATE Classe SET nomClasse = '" & valeur_classe & "' WHERE idClasse = " & selectedId
                Dim cmd As New OleDbCommand(requete, maconnexion)
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Mise à jour réussie")
                End If
                selectedId = 0 ' Réinitialiser l'ID sélectionné
            End If

            maconnexion.Close()
            Call recuperation_data()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Classe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call recuperation_data()
    End Sub


    Private Sub Btn_supp_Click(sender As Object, e As EventArgs) Handles Btn_supp.Click
        Dim ligne As Integer = Tableau_classe.CurrentRow().Index ''recuperer index de la ligne selectionné''

        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette classe?", "Confirmation de suppression", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Supprimer le client de la base de données
            Dim v_id As String = Tableau_classe.Rows(ligne).Cells("num_classe").Value ''obtention de l'id''
            supprimer_data(v_id)

            ' Réinitialiser la valeur de selectedId
            selectedId = 0

            ' Actualiser les données du tableau
            Call recuperation_data()
            MessageBox.Show(" Ligne: " & ligne & " - ID: " & v_id)
        End If
    End Sub

    Private Sub Btn_selection_Click(sender As Object, e As EventArgs) Handles Btn_selection.Click
        Dim ligne As String = Tableau_classe.CurrentRow().Index
        Dim v_id As String = Tableau_classe.Rows(ligne).Cells("num_classe").Value ''obtention de l'id''
        classe_champs.Text = Tableau_classe.Rows(ligne).Cells("nom_classe").Value
        selectedId = v_id
    End Sub
End Class