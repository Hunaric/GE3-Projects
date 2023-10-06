Imports System.Data.OleDb

Public Class BulletinClasse
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

    Private Sub BulletinClasse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valeur_classe.Text = RecupererClasseName(_numeroClasse)
    End Sub
End Class