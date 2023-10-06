Imports System.Data.OleDb

Public Class BulletinIndividuel
    Dim projetPath As String = Application.StartupPath
    Dim dataBasePath As String = projetPath & "\BD\bd.accdb"
    Private chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dataBasePath & ";Persist Security Info=False"

    Private _numeroEtudiant As Integer

    Public Property NumeroEtudiant As Integer
        Get
            Return _numeroEtudiant
        End Get
        Set(value As Integer)
            _numeroEtudiant = value
        End Set
    End Property


    'RECHERCHE MATRICULE
    Public Class Etudian
        Public Property ID As Integer
        Public Property Nom As String
        Public Property Prenom As String
        Public Property Sexe As String
        Public Property DateNaissance As DateTime
        Public Property LieuNaissance As String
        Public Property NumeroMatricule As String
        Public Property IdClasse As Integer


        Public Sub New(id As Integer, nom As String, prenom As String, sexe As String, dateNaissance As DateTime, lieuNaissance As String, numeroMatricule As String, idClasse As Integer)
            Me.ID = id
            Me.Nom = nom
            Me.Prenom = prenom
            Me.Sexe = sexe
            Me.DateNaissance = dateNaissance
            Me.LieuNaissance = lieuNaissance
            Me.NumeroMatricule = numeroMatricule
            Me.IdClasse = idClasse
        End Sub
    End Class

    Private Sub MiseAJourInfoEtu(numEtudiant)

        Using connection As New OleDbConnection(chemin)
            connection.Open()

            Dim query As String = "SELECT * FROM Etudiant WHERE idEtudiant = @numEtudiant"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@numEtudiant", numEtudiant)

                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Dim etudiantNom As String = reader("nom").ToString()
                    Dim etudiantPrenom As String = reader("prenom").ToString()
                    Dim etudiantSexe As String = reader("sexe").ToString()
                    Dim etudiantDate As DateTime = Convert.ToDateTime(reader("dateNaissance"))
                    Dim etudiantLieu As String = reader("lieuNaissance").ToString()
                    Dim etudiantMatr As String = reader("numeroMatricule").ToString()
                    Dim etudiantIdClasse As Integer = Convert.ToInt32(reader("idClasse"))
                    Dim student As New Etudian(numEtudiant, etudiantNom, etudiantPrenom, etudiantSexe, etudiantDate, etudiantLieu, etudiantMatr, etudiantIdClasse)

                    valeur_nom.Text = student.Nom
                    valeur_prenom.Text = student.Prenom
                    valeur_date.Text = student.DateNaissance.ToString()
                    valeur_sexe.Text = student.Sexe
                    valeur_lieu.Text = student.LieuNaissance
                    valeur_num_matr.Text = student.NumeroMatricule
                    valeur_classe.Text = RecupererClasseName(student.IdClasse)
                End If
            End Using
        End Using
    End Sub

    Private Function RecupererClasseName(numClasse As Integer) As String
        Using maconnexion As New OleDbConnection(chemin)
            maconnexion.Open()

            Dim queryClasse As String = "SELECT nomClasse FROM Classe WHERE idClasse = @idClasse"
            Using cmdNomClasse As New OleDbCommand(queryClasse, maconnexion)
                cmdNomClasse.Parameters.AddWithValue("@idClasse", numClasse)
                Dim nomClasse As String = CStr(cmdNomClasse.ExecuteScalar())
                Return nomClasse
            End Using
        End Using
    End Function

    Private Sub BulletinIndividuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MiseAJourInfoEtu(_numeroEtudiant)
    End Sub
End Class