Imports System.Data.OleDb

Public Class InfoEtudiant
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
    Private Sub InfoEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class