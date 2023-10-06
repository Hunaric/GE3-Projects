Imports System.Data.OleDb

Public Class EnrEtudiant
    Dim projetPath As String = Application.StartupPath
    Dim dataBasePath As String = projetPath & "\BD\bd.accdb"
    Private chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dataBasePath & ";Persist Security Info=False"

    'DEBUT LISTE DEROULANTE CLASSE
    Private classeSelectionneId As Integer

    Public Class ClasseEcole
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

    Private classes As List(Of ClasseEcole)

    'FONCTION POUR LA LISTE DEROULANTE CLASSE 
    Private Sub ComboClasse()
        Using connection As New OleDbConnection(Me.chemin)
            connection.Open()

            Dim query As String = "SELECT idClasse, nomClasse FROM Classe"
            Dim command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            While reader.Read()
                Dim classeId As Integer = Convert.ToInt32(reader("idClasse"))
                Dim classeName As String = reader("nomClasse").ToString()
                Dim classe As New ClasseEcole(classeId, classeName)
                classes.Add(classe)
                combo_classe.Items.Add(classe)
            End While

            reader.Close()
        End Using
    End Sub

    'FOCNTION POUR TROUVER LA CLASSE
    Private Function ClasseSelectionneeName(classeId As Integer) As String
        Dim classeSelectionne As ClasseEcole = classes.FirstOrDefault(Function(c) c.Id = classeId)
        If classeSelectionne IsNot Nothing Then
            Return classeSelectionne.Nom
        Else
            Return String.Empty ' ou une valeur par défaut si l'ID n'est pas trouvé
        End If
    End Function

    'FOCNTION POUR TROUVER LE ID DE LA CLASSE
    Private Function ClasseRecupereId(classeName As String) As Integer
        Dim classeSelectionne As ClasseEcole = classes.FirstOrDefault(Function(c) c.Nom = classeName)
        If classeSelectionne IsNot Nothing Then
            Return classeSelectionne.Id
        Else
            Return -1 ' ou une valeur par défaut si le nom n'est pas trouvé
        End If
    End Function

    'LISTE DEROULANTE CLASSE
    Private Sub combo_classe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_classe.SelectedIndexChanged
        Dim classeSelectionne As ClasseEcole = DirectCast(combo_classe.SelectedItem, ClasseEcole)
        classeSelectionneId = classeSelectionne.Id
    End Sub
    'FIN 

    Dim debutMat As String = "RC01A00"

    'FONCTION POUR RECUPERER L ID DU DERNIERE ETUDIANT 
    Private Function GetLastStudent() As Integer
        Dim lastStudentId As Integer = 0

        Try
            Using maconnexion As New OleDbConnection(chemin)
                maconnexion.Open()

                Dim requete As String = "SELECT MAX(idEtudiant) FROM Etudiant"
                Dim cmd As New OleDbCommand(requete, maconnexion)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    lastStudentId = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'opération : " & ex.Message)
        End Try

        Return lastStudentId
    End Function

    'ENREGISTREMENT ETUDIANT

    Private Sub Btn_enr_Click(sender As Object, e As EventArgs) Handles Btn_enr.Click
        Dim v_nom, v_prenom, v_date_sel, v_date, v_lieu, v_sexe, v_classe, v_num, v_id_incr As String
        v_nom = champs_nom.Text
        v_prenom = champs_prenom.Text
        v_date_sel = champs_date.Value
        v_date = DateTime.Parse(v_date_sel).ToString("dd/MM/yyyy")
        v_lieu = champs_lieu.Text
        v_classe = classeSelectionneId
        v_id_incr = GetLastStudent() + 1
        v_num = debutMat & v_id_incr

        v_sexe = champs_sexe_masc.Text
        If champs_sexe_fem.Checked Then
            v_sexe = champs_sexe_fem.Text
        End If

        If v_classe <> 0 Then

            Try
                Dim maconnexion As New OleDbConnection(Me.chemin)
                maconnexion.Open()
                Dim requete As String = "INSERT INTO Etudiant(nom, prenom, sexe, dateNaissance, lieuNaissance, numeroMatricule, idClasse) VALUES('" & v_nom & "', '" & v_prenom & "', '" & v_sexe & "', '" & v_date & "', '" & v_lieu & "', '" & v_num & "', '" & v_classe & "')"
                Dim cmd As New OleDbCommand(requete, maconnexion)
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("L'élève " & v_nom & " " & v_prenom & " a été ajouté dans la classe " & ClasseSelectionneeName(v_classe))
                End If
            Catch ex As Exception
                MessageBox.Show("Erreur lors de la sauvegarde de l'élève.")
            End Try
        Else
            MessageBox.Show("Veuillez sélectionner un classe.")

        End If

    End Sub

    Private Sub EnrEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        classes = New List(Of ClasseEcole)()
        ComboClasse()
        Dim v_id_incr, v_num As String
        v_id_incr = GetLastStudent() + 1
        v_num = debutMat & v_id_incr
        champs_matr.Text = v_num
    End Sub
End Class