Imports System.Data.OleDb

Public Class Accueil
    Dim projetPath As String = Application.StartupPath
    Dim dataBasePath As String = projetPath & "\BD\bd.accdb"
    Private chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dataBasePath & ";Persist Security Info=False"

    'DEBUT LISTE DEROULANTE CLASSE
    Private classeSelectionneId1 As Integer
    Private classeSelectionneId3 As Integer
    Private classeSelectionneId4 As Integer
    Private etudiantsSelected1 As Integer
    Private etudiantsSelected2 As Integer

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
                ComboBox1.Items.Add(classe)
                ComboBox3.Items.Add(classe)
                ComboBox4.Items.Add(classe)
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
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim classeSelectionne As ClasseEcole = DirectCast(ComboBox1.SelectedItem, ClasseEcole)
        classeSelectionneId1 = classeSelectionne.Id
        etudiants = New List(Of Etudiant)()
        ComboBox2.Items.Clear()
        ComboBox2.SelectedIndex = -1
        ComboEtudiant()
    End Sub
    'FIN 

    Private Sub Btn_show_list_etu_Click(sender As Object, e As EventArgs) Handles Btn_show_list_etu.Click
        Dim numClasse = classeSelectionneId4
        Dim numeroClasse As Integer = numClasse ' Remplacez cette valeur par la valeur réelle de votre numéro de classe

        Dim afficherListe As New ListeEtiduant()
        afficherListe.NumeroClasse = numeroClasse ' Définir la valeur de NumeroClasse dans la fenêtre ListeEtudiant

        afficherListe.Show() ' Afficher la fenêtre ListeEtudiant
    End Sub

    Private Sub Btn_save_type_note_Click(sender As Object, e As EventArgs) Handles Btn_save_type_note.Click
        TypeNote.Show()
    End Sub

    Private Sub Btn_matiere_Click(sender As Object, e As EventArgs) Handles Btn_matiere.Click
        Matiere.Show()
    End Sub

    Private Sub Btn_classe_Click(sender As Object, e As EventArgs) Handles Btn_classe.Click
        Classe.Show()
    End Sub

    Private Sub Btn_add_etu_Click(sender As Object, e As EventArgs) Handles Btn_add_etu.Click
        EnrEtudiant.Show()
    End Sub

    Private Sub Btn_add_note_Click(sender As Object, e As EventArgs) Handles Btn_add_note.Click
        Dim numClasse = classeSelectionneId3
        Dim numeroClasse As Integer = numClasse ' Remplacez cette valeur par la valeur réelle de votre numéro de classe
        Dim afficherListe As New ListeEtiduant()
        afficherListe.NumeroClasse = numeroClasse ' Définir la valeur de NumeroClasse dans la fenêtre ListeEtudiant

        afficherListe.Show() ' Afficher la fenêtre ListeEtudiant
    End Sub

    Private Sub Btn_show_bulletin_class_Click(sender As Object, e As EventArgs) Handles Btn_show_bulletin_class.Click
        Dim numClasse = classeSelectionneId1
        Dim numeroClasse As Integer = numClasse ' Remplacez cette valeur par la valeur réelle de votre numéro de classe

        Dim afficherListe As New BulletinClasse()
        afficherListe.NumeroClasse = numeroClasse ' Définir la valeur de NumeroClasse dans la fenêtre ListeEtudiant

        afficherListe.Show() ' Afficher la fenêtre ListeEtudiant
    End Sub

    Private Sub Btn_show_bulletin_etu_Click(sender As Object, e As EventArgs) Handles Btn_show_bulletin_etu.Click
        Dim numEtudiant = etudiantsSelected2
        Dim numeroEtudiant As Integer = numEtudiant ' Remplacez cette valeur par la valeur réelle de votre numéro d'etudiant

        Dim afficherListe As New BulletinIndividuel()
        afficherListe.NumeroEtudiant = numeroEtudiant ' Définir la valeur de NumeroClasse dans la fenêtre BulletinIndividuel

        afficherListe.Show() ' Afficher la fenêtre BulletinIndividuel
    End Sub

    Private Sub Btn_bulletin_eleve_Click(sender As Object, e As EventArgs) Handles Btn_bulletin_eleve.Click
        Dim numEtudiant = etudiantsSelected1
        Dim numeroEtudiant As Integer = numEtudiant ' Remplacez cette valeur par la valeur réelle de votre numéro d'etudiant

        Dim afficherListe As New BulletinIndividuel()
        afficherListe.NumeroEtudiant = numeroEtudiant ' Définir la valeur de NumeroClasse dans la fenêtre BulletinIndividuel

        afficherListe.Show() ' Afficher la fenêtre BulletinIndividuel
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        classes = New List(Of ClasseEcole)()
        ComboClasse()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim classeSelectionne As ClasseEcole = DirectCast(ComboBox4.SelectedItem, ClasseEcole)
        classeSelectionneId4 = classeSelectionne.Id
    End Sub

    'FONCTION POUR ETUDIANT

    Public Class Etudiant
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

    Private etudiants As List(Of Etudiant)

    'FONCTION POUR LA LISTE DEROULANTE ETUDIANT 
    Private Sub ComboEtudiant()
        Using connection As New OleDbConnection(Me.chemin)
            connection.Open()


            Dim query As String = "SELECT idEtudiant, nom, prenom FROM Etudiant WHERE idClasse = " & classeSelectionneId1
            Dim command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            While reader.Read()
                Dim etudiantId As Integer = Convert.ToInt32(reader("idEtudiant"))
                Dim etudiantName As String = reader("nom").ToString()
                Dim etudiantPrenom As String = reader("prenom").ToString()
                Dim etudiantNomComplet As String = etudiantName & " " & etudiantPrenom
                Dim etudiant As New Etudiant(etudiantId, etudiantNomComplet)
                etudiants.Add(etudiant)
                ComboBox2.Items.Add(etudiant)
            End While

            reader.Close()
        End Using
    End Sub

    'FOCNTION POUR TROUVER LA ETUDIANT
    Private Function EtudiantSelectionneeName(etudiantId As Integer) As String
        Dim etudiantSelectionne As Etudiant = etudiants.FirstOrDefault(Function(c) c.Id = etudiantId)
        If etudiantSelectionne IsNot Nothing Then
            Return etudiantSelectionne.Nom
        Else
            Return String.Empty ' ou une valeur par défaut si l'ID n'est pas trouvé
        End If
    End Function

    'FOCNTION POUR TROUVER LE ID DE LA ETUDIANT
    Private Function EtudiantRecupereId(etudiantName As String) As Integer
        Dim etudiantSelectionne As Etudiant = etudiants.FirstOrDefault(Function(c) c.Nom = etudiantName)
        If etudiantSelectionne IsNot Nothing Then
            Return etudiantSelectionne.Id
        Else
            Return -1 ' ou une valeur par défaut si le nom n'est pas trouvé
        End If
    End Function

    'LISTE DEROULANTE ETUDIANT
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim etudiantSelectionne As Etudiant = DirectCast(ComboBox2.SelectedItem, Etudiant)
        etudiantsSelected2 = etudiantSelectionne.Id
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim classeSelectionne As ClasseEcole = DirectCast(ComboBox3.SelectedItem, ClasseEcole)
        classeSelectionneId3 = classeSelectionne.Id

    End Sub

    'FIN 

    'RECHERCHE MATRICULE
    Public Class Etudian
        Public Property ID As Integer
        Public Property Nom As String
        Public Property Prenom As String
        Public Property Sexe As String
        Public Property DateNaissance As DateTime
        Public Property NumeroMatricule As String
        Public Property IdClasse As Integer


        Public Sub New(id As Integer, nom As String, prenom As String, sexe As String, dateNaissance As DateTime, numeroMatricule As String, idClasse As Integer)
            Me.ID = id
            Me.Nom = nom
            Me.Prenom = prenom
            Me.Sexe = sexe
            Me.DateNaissance = dateNaissance
            Me.NumeroMatricule = numeroMatricule
            Me.IdClasse = idClasse
        End Sub
    End Class

    Private Sub Btn_search_matricul_Click(sender As Object, e As EventArgs) Handles Btn_search_matricul.Click
        Dim Numero_matricule_rech As String = champs_rech.Text

        valeur_nom.Visible = False
        valeur_matricule.Visible = False
        valeur_sexe.Visible = False
        valeur_date.Visible = False
        valeur_prenom.Visible = False
        valeur_classe.Visible = False
        empty_search.Visible = False
        Btn_bulletin_eleve.Visible = False

        nom_eleve_search.Visible = False
        prenom_eleve_search.Visible = False
        date_eleve_search.Visible = False
        num_matr_eleve_search.Visible = False
        sexe_eleve_search.Visible = False
        classe_eleve_search.Visible = False

        Using connection As New OleDbConnection(chemin)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM Etudiant WHERE numeroMatricule = @numRech"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@numRech", Numero_matricule_rech)
                Dim count As Integer = CInt(command.ExecuteScalar())
                If count > 0 Then
                    Dim query2 As String = "SELECT * FROM Etudiant WHERE numeroMatricule = @numRech"
                    Using cmd1 As New OleDbCommand(query2, connection)
                        cmd1.Parameters.AddWithValue("@numRech", Numero_matricule_rech)
                        Dim reader As OleDbDataReader = cmd1.ExecuteReader()
                        If reader.Read() Then
                            Dim etudiantId As Integer = Convert.ToInt32(reader("idEtudiant"))
                            Dim etudiantNom As String = reader("nom").ToString()
                            Dim etudiantPrenom As String = reader("prenom").ToString()
                            Dim etudiantSexe As String = reader("sexe").ToString()
                            Dim etudiantDate As DateTime = Convert.ToDateTime(reader("dateNaissance"))
                            Dim etudiantIdClasse As Integer = Convert.ToInt32(reader("idClasse"))
                            Dim student As New Etudian(etudiantId, etudiantNom, etudiantPrenom, etudiantSexe, etudiantDate, Numero_matricule_rech, etudiantIdClasse)

                            nom_eleve_search.Visible = True
                            prenom_eleve_search.Visible = True
                            date_eleve_search.Visible = True
                            num_matr_eleve_search.Visible = True
                            sexe_eleve_search.Visible = True
                            classe_eleve_search.Visible = True

                            valeur_nom.Text = student.Nom
                            valeur_nom.Visible = True
                            valeur_prenom.Text = student.Prenom
                            valeur_prenom.Visible = True
                            valeur_date.Text = student.DateNaissance.ToString()
                            valeur_date.Visible = True
                            valeur_sexe.Text = student.Sexe
                            valeur_sexe.Visible = True
                            valeur_matricule.Text = student.NumeroMatricule
                            valeur_matricule.Visible = True
                            valeur_classe.Text = RecupererClasseName(student.IdClasse)
                            valeur_classe.Visible = True
                            Btn_bulletin_eleve.Visible = True
                            etudiantsSelected1 = student.ID
                        End If
                    End Using
                Else
                    empty_search.Visible = True
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


End Class
