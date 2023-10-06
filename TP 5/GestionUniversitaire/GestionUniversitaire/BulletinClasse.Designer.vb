<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulletinClasse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nom_eleve_search = New System.Windows.Forms.Label()
        Me.valeur_classe = New System.Windows.Forms.Label()
        Me.Btn_print = New System.Windows.Forms.Button()
        Me.Tableau_bulletin = New System.Windows.Forms.DataGridView()
        Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_moy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_rang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Tableau_bulletin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 42)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "BULLETIN"
        '
        'nom_eleve_search
        '
        Me.nom_eleve_search.AutoSize = True
        Me.nom_eleve_search.Location = New System.Drawing.Point(56, 76)
        Me.nom_eleve_search.Name = "nom_eleve_search"
        Me.nom_eleve_search.Size = New System.Drawing.Size(54, 13)
        Me.nom_eleve_search.TabIndex = 32
        Me.nom_eleve_search.Text = "CLASSE :"
        '
        'valeur_classe
        '
        Me.valeur_classe.AutoSize = True
        Me.valeur_classe.Location = New System.Drawing.Point(132, 76)
        Me.valeur_classe.Name = "valeur_classe"
        Me.valeur_classe.Size = New System.Drawing.Size(38, 13)
        Me.valeur_classe.TabIndex = 33
        Me.valeur_classe.Text = "NOM :"
        '
        'Btn_print
        '
        Me.Btn_print.Location = New System.Drawing.Point(340, 71)
        Me.Btn_print.Name = "Btn_print"
        Me.Btn_print.Size = New System.Drawing.Size(207, 23)
        Me.Btn_print.TabIndex = 34
        Me.Btn_print.Text = "IMPRIMER"
        Me.Btn_print.UseVisualStyleBackColor = True
        '
        'Tableau_bulletin
        '
        Me.Tableau_bulletin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tableau_bulletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tableau_bulletin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_nom, Me.col_moy, Me.col_rang})
        Me.Tableau_bulletin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tableau_bulletin.Location = New System.Drawing.Point(0, 130)
        Me.Tableau_bulletin.Name = "Tableau_bulletin"
        Me.Tableau_bulletin.Size = New System.Drawing.Size(786, 393)
        Me.Tableau_bulletin.TabIndex = 35
        '
        'col_num
        '
        Me.col_num.HeaderText = "NUMERO"
        Me.col_num.Name = "col_num"
        '
        'col_nom
        '
        Me.col_nom.HeaderText = "NOM"
        Me.col_nom.Name = "col_nom"
        '
        'col_moy
        '
        Me.col_moy.HeaderText = "MOYENNE"
        Me.col_moy.Name = "col_moy"
        '
        'col_rang
        '
        Me.col_rang.FillWeight = 30.0!
        Me.col_rang.HeaderText = "RANG"
        Me.col_rang.Name = "col_rang"
        '
        'BulletinClasse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 523)
        Me.Controls.Add(Me.Tableau_bulletin)
        Me.Controls.Add(Me.Btn_print)
        Me.Controls.Add(Me.valeur_classe)
        Me.Controls.Add(Me.nom_eleve_search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BulletinClasse"
        Me.Text = "BulletinClasse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Tableau_bulletin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nom_eleve_search As Label
    Friend WithEvents valeur_classe As Label
    Friend WithEvents Btn_print As Button
    Friend WithEvents Tableau_bulletin As DataGridView
    Friend WithEvents col_num As DataGridViewTextBoxColumn
    Friend WithEvents col_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_moy As DataGridViewTextBoxColumn
    Friend WithEvents col_rang As DataGridViewTextBoxColumn
End Class
