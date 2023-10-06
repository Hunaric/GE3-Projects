<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeEtiduant
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.valeur_classe = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.valeur_matiere = New System.Windows.Forms.ComboBox()
        Me.Tableau_liste_etu = New System.Windows.Forms.DataGridView()
        Me.nom_etu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom_etu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_etu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note_valeur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_note_valeur = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_ajout = New System.Windows.Forms.Button()
        CType(Me.Tableau_liste_etu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 42)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "LISTE ETUDIANT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(455, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "CLASSE :"
        '
        'valeur_classe
        '
        Me.valeur_classe.AutoSize = True
        Me.valeur_classe.Location = New System.Drawing.Point(537, 77)
        Me.valeur_classe.Name = "valeur_classe"
        Me.valeur_classe.Size = New System.Drawing.Size(69, 13)
        Me.valeur_classe.TabIndex = 30
        Me.valeur_classe.Text = "valeur classe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "MATIERE :"
        '
        'valeur_matiere
        '
        Me.valeur_matiere.FormattingEnabled = True
        Me.valeur_matiere.Location = New System.Drawing.Point(151, 74)
        Me.valeur_matiere.Name = "valeur_matiere"
        Me.valeur_matiere.Size = New System.Drawing.Size(135, 21)
        Me.valeur_matiere.TabIndex = 32
        '
        'Tableau_liste_etu
        '
        Me.Tableau_liste_etu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tableau_liste_etu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tableau_liste_etu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tableau_liste_etu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom_etu, Me.prenom_etu, Me.id_etu, Me.note_valeur})
        Me.Tableau_liste_etu.Location = New System.Drawing.Point(40, 177)
        Me.Tableau_liste_etu.Name = "Tableau_liste_etu"
        Me.Tableau_liste_etu.Size = New System.Drawing.Size(611, 241)
        Me.Tableau_liste_etu.TabIndex = 33
        '
        'nom_etu
        '
        Me.nom_etu.HeaderText = "NOM"
        Me.nom_etu.Name = "nom_etu"
        Me.nom_etu.ReadOnly = True
        '
        'prenom_etu
        '
        Me.prenom_etu.HeaderText = "PRENOM"
        Me.prenom_etu.Name = "prenom_etu"
        Me.prenom_etu.ReadOnly = True
        '
        'id_etu
        '
        Me.id_etu.HeaderText = "ID"
        Me.id_etu.Name = "id_etu"
        Me.id_etu.Visible = False
        '
        'note_valeur
        '
        Me.note_valeur.HeaderText = "NOTE"
        Me.note_valeur.Name = "note_valeur"
        '
        'type_note_valeur
        '
        Me.type_note_valeur.FormattingEnabled = True
        Me.type_note_valeur.Location = New System.Drawing.Point(151, 115)
        Me.type_note_valeur.Name = "type_note_valeur"
        Me.type_note_valeur.Size = New System.Drawing.Size(135, 21)
        Me.type_note_valeur.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "TYPE DE NOTE :"
        '
        'Btn_ajout
        '
        Me.Btn_ajout.Location = New System.Drawing.Point(458, 113)
        Me.Btn_ajout.Name = "Btn_ajout"
        Me.Btn_ajout.Size = New System.Drawing.Size(207, 23)
        Me.Btn_ajout.TabIndex = 36
        Me.Btn_ajout.Text = "ENREGISTRER"
        Me.Btn_ajout.UseVisualStyleBackColor = True
        '
        'ListeEtiduant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 471)
        Me.Controls.Add(Me.Btn_ajout)
        Me.Controls.Add(Me.type_note_valeur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tableau_liste_etu)
        Me.Controls.Add(Me.valeur_matiere)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.valeur_classe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListeEtiduant"
        Me.Text = "ListeEtiduant"
        CType(Me.Tableau_liste_etu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents valeur_classe As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents valeur_matiere As ComboBox
    Friend WithEvents Tableau_liste_etu As DataGridView
    Friend WithEvents type_note_valeur As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_ajout As Button
    Friend WithEvents nom_etu As DataGridViewTextBoxColumn
    Friend WithEvents prenom_etu As DataGridViewTextBoxColumn
    Friend WithEvents id_etu As DataGridViewTextBoxColumn
    Friend WithEvents note_valeur As DataGridViewTextBoxColumn
End Class
