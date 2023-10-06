Imports System.Data.OleDb

Public Class ListeEtiduant
    Dim projetPath As String = Application.StartupPath
    Dim dataBasePath As String = projetPath & "\BD\bd.accdb"
    Private chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dataBasePath & ";Persist Security Info=False"

    Private _numeroClasse As Integer

    Public Property NumeroClasse As Integer
        Get
            Return _numeroClasse
        End Get
        Set(value As Integer)
            _numeroClasse = value
        End Set
    End Property

    'DEBUT LISTE DEROULANTE MATIERE
    Private matiereSelectionneId As Integer

    Public Class Matiere
        Public Property Id As Integer
        Public Property Nom As String
        Public Property Coef As String
        Public Sub New(id As Integer, nom As String, coef As Integer)
            Me.Id = id
            Me.Nom = nom
            Me.Coef = coef
        End Sub

        Public Overrides Function ToString() As String
            Return Nom
        End Function
    End Class

    Private matieres As List(Of Matiere)

    'FONCTION POUR LA LISTE DEROULANTE MATIERE 
    Private Sub ComboMatiere()
        Using connection As New OleDbConnection(Me.chemin)
            connection.Open()

            Dim query As String = "SELECT idMatiere, nomMatiere, coef FROM Matiere"
            Dim command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            While reader.Read()
                Dim matiereId As Integer = Convert.ToInt32(reader("idMatiere"))
                Dim matiereName As String = reader("nomMatiere").ToString()
                Dim matiereCoef As Integer = Convert.ToInt32(reader("coef"))
                Dim matiere As New Matiere(matiereId, matiereName, matiereCoef)
                matieres.Add(matiere)
                valeur_matiere.Items.Add(matiere)
            End While

            reader.Close()
        End Using
    End Sub

    'FOCNTION POUR TROUVER LA MATIERE
    Private Function MatiereSelectionneeName(matiereId As Integer) As String
        Dim matiereSelectionne As Matiere = matieres.FirstOrDefault(Function(c) c.Id = matiereId)
        If matiereSelectionne IsNot Nothing Then
            Return matiereSelectionne.Nom
        Else
            Return String.Empty ' ou une valeur par défaut si l'ID n'est pas trouvé
        End If
    End Function

    'FOCNTION POUR TROUVER LE ID DE LA MATIERE
    Private Function MatiereRecupereId(matiereName As String) As Integer
        Dim matiereSelectionne As Matiere = matieres.FirstOrDefault(Function(c) c.Nom = matiereName)
        If matiereSelectionne IsNot Nothing Then
            Return matiereSelectionne.Id
        Else
            Return -1 ' ou une valeur par défaut si le nom n'est pas trouvé
        End If
    End Function

    'LISTE DEROULANTE MATIERE
    Private Sub valeur_matiere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles valeur_matiere.SelectedIndexChanged
        Dim matiereSelectionne As Matiere = DirectCast(valeur_matiere.SelectedItem, Matiere)
        matiereSelectionneId = matiereSelectionne.Id
    End Sub
    'FIN 


    'DEBUT LISTE DEROULANTE TYPE NOTE
    Private typeNoteSelectionneId As Integer

    Public Class TypeNote
        Public Property Id As Integer
        Public Property Nom As String
        Public Sub New(id As Integer, nom As String)
            Me.Id = id
            Me.Nom = nom
        End Sub

        Public Overrides Function ToString() As String
            Return Nom
        End Function
    End Class

    Private typeNotes As List(Of TypeNote)

    'FONCTION POUR LA LISTE DEROULANTE TYPE NOTE 
    Private Sub ComboTypeNote()
        Using connection As New OleDbConnection(Me.chemin)
            connection.Open()

            Dim query As String = "SELECT idTypeNote, libelleType FROM TypeNote"
            Dim command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            While reader.Read()
                Dim typeNoteId As Integer = Convert.ToInt32(reader("idTypeNote"))
                Dim typeNoteName As String = reader("libelleType").ToString()
                Dim typeNote As New TypeNote(typeNoteId, typeNoteName)
                typeNotes.Add(typeNote)
                type_note_valeur.Items.Add(typeNote)
            End While

            reader.Close()
        End Using
    End Sub

    'FOCNTION POUR TROUVER LA TYPE NOTE
    Private Function TyepMatiereSelectionneeName(typeNoteId As Integer) As String
        Dim typeNoteSelectionne As TypeNote = typeNotes.FirstOrDefault(Function(c) c.Id = typeNoteId)
        If typeNoteSelectionne IsNot Nothing Then
            Return typeNoteSelectionne.Nom
        Else
            Return String.Empty ' ou une valeur par défaut si l'ID n'est pas trouvé
        End If
    End Function

    'FOCNTION POUR TROUVER LE ID DE LA TYPE NOTE
    Private Function TypeNoteRecupereId(typeNoteName As String) As Integer
        Dim typeNoteSelectionne As TypeNote = typeNotes.FirstOrDefault(Function(c) c.Nom = typeNoteName)
        If typeNoteSelectionne IsNot Nothing Then
            Return typeNoteSelectionne.Id
        Else
            Return -1 ' ou une valeur par défaut si le nom n'est pas trouvé
        End If
    End Function

    'LISTE DEROULANTE TYPE NOTE
    Private Sub type_note_valeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles type_note_valeur.SelectedIndexChanged
        Dim typeNoteSelectionne As TypeNote = DirectCast(type_note_valeur.SelectedItem, TypeNote)
        typeNoteSelectionneId = typeNoteSelectionne.Id
    End Sub
    'FIN 


    Public Sub Recuperation_infos(numClasse As Integer)
        Try
            Using maconnexion As New OleDbConnection(chemin)
                maconnexion.Open()

                ' Récupérer nom classe
                Dim requeteNomClasse As String = "SELECT nomClasse FROM Classe WHERE idClasse = @numClasse"
                Using cmdNomClasse As New OleDbCommand(requeteNomClasse, maconnexion)
                    cmdNomClasse.Parameters.AddWithValue("@numClasse", numClasse)
                    Dim nomClasse As String = CStr(cmdNomClasse.ExecuteScalar())
                    valeur_classe.Text = nomClasse
                End Using

                ' Récupérer les étudiants
                Dim requeteEtudiants As String = "SELECT idEtudiant, nom, prenom FROM Etudiant WHERE idClasse = @numClasse"
                Using cmdEtudiants As New OleDbCommand(requeteEtudiants, maconnexion)
                    cmdEtudiants.Parameters.AddWithValue("@numClasse", numClasse)
                    Dim mes_donnes As OleDbDataReader
                    mes_donnes = cmdEtudiants.ExecuteReader()

                    Do While mes_donnes.Read()

                        Tableau_liste_etu.Rows.Add(mes_donnes.Item("nom"), mes_donnes.Item("prenom"), mes_donnes.Item("idEtudiant"))
                    Loop

                End Using

                maconnexion.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la récupération des données : " & ex.Message)
        End Try
    End Sub

    'DEBUT ENREGISTREMENT NOTE
    Private Sub EnregistrerNotes()
        Using connection As New OleDbConnection(chemin)
            connection.Open()

            Dim query As String = "INSERT INTO Feuille(idEtudiant, idMatiere, idTypeNote, valeurNote) VALUES (@idEtudiant, @idMatiere, @idTypeNote, @valeur)"
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@idEtudiant", DBNull.Value)
            command.Parameters.AddWithValue("@idMatiere", DBNull.Value)
            command.Parameters.AddWithValue("@idTypeNote", DBNull.Value)
            command.Parameters.AddWithValue("@valeurNote", DBNull.Value)

            For Each row As DataGridViewRow In Tableau_liste_etu.Rows
                Dim idEtudiant As Integer = Convert.ToInt32(row.Cells("id_etu").Value)
                Dim valeurNote As Double

                Dim cellValue As Object = row.Cells("note_valeur").Value
                If cellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(cellValue.ToString()) Then
                    If Double.TryParse(row.Cells("note_valeur").Value.ToString(), valeurNote) Then
                        command.Parameters("@idEtudiant").Value = idEtudiant
                        command.Parameters("@idMatiere").Value = matiereSelectionneId
                        command.Parameters("@idTypeNote").Value = typeNoteSelectionneId
                        command.Parameters("@valeurNote").Value = valeurNote
                        command.ExecuteNonQuery()
                    End If
                End If
            Next
        End Using
    End Sub


    Private Sub ListeEtiduant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        matieres = New List(Of Matiere)()
        ComboMatiere()
        typeNotes = New List(Of TypeNote)()
        ComboTypeNote()
        Call Recuperation_infos(_numeroClasse)
    End Sub

    Private Sub Btn_ajout_Click(sender As Object, e As EventArgs) Handles Btn_ajout.Click
        EnregistrerNotes()
        MessageBox.Show("Les notes ont été enregistrées avec succès")
    End Sub
End Class