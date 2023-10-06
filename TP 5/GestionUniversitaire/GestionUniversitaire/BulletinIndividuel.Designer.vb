<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulletinIndividuel
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
        Me.valeur_classe = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.valeur_num_matr = New System.Windows.Forms.Label()
        Me.valeur_lieu = New System.Windows.Forms.Label()
        Me.valeur_date = New System.Windows.Forms.Label()
        Me.valeur_sexe = New System.Windows.Forms.Label()
        Me.valeur_prenom = New System.Windows.Forms.Label()
        Me.valeur_nom = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nom_ = New System.Windows.Forms.Label()
        Me.Tableau_bulletin = New System.Windows.Forms.DataGridView()
        Me.col_matiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_coef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_moy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_moy_coef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_etu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valeur_moy = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.valeur_rang = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btn_print = New System.Windows.Forms.Button()
        CType(Me.Tableau_bulletin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'valeur_classe
        '
        Me.valeur_classe.AutoSize = True
        Me.valeur_classe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_classe.Location = New System.Drawing.Point(547, 113)
        Me.valeur_classe.Name = "valeur_classe"
        Me.valeur_classe.Size = New System.Drawing.Size(53, 20)
        Me.valeur_classe.TabIndex = 56
        Me.valeur_classe.Text = "NOM :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(460, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "CLASSE :"
        '
        'valeur_num_matr
        '
        Me.valeur_num_matr.AutoSize = True
        Me.valeur_num_matr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_num_matr.Location = New System.Drawing.Point(547, 75)
        Me.valeur_num_matr.Name = "valeur_num_matr"
        Me.valeur_num_matr.Size = New System.Drawing.Size(53, 20)
        Me.valeur_num_matr.TabIndex = 54
        Me.valeur_num_matr.Text = "NOM :"
        '
        'valeur_lieu
        '
        Me.valeur_lieu.AutoSize = True
        Me.valeur_lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_lieu.Location = New System.Drawing.Point(262, 220)
        Me.valeur_lieu.Name = "valeur_lieu"
        Me.valeur_lieu.Size = New System.Drawing.Size(53, 20)
        Me.valeur_lieu.TabIndex = 53
        Me.valeur_lieu.Text = "NOM :"
        '
        'valeur_date
        '
        Me.valeur_date.AutoSize = True
        Me.valeur_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_date.Location = New System.Drawing.Point(262, 186)
        Me.valeur_date.Name = "valeur_date"
        Me.valeur_date.Size = New System.Drawing.Size(53, 20)
        Me.valeur_date.TabIndex = 52
        Me.valeur_date.Text = "NOM :"
        '
        'valeur_sexe
        '
        Me.valeur_sexe.AutoSize = True
        Me.valeur_sexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_sexe.Location = New System.Drawing.Point(262, 151)
        Me.valeur_sexe.Name = "valeur_sexe"
        Me.valeur_sexe.Size = New System.Drawing.Size(53, 20)
        Me.valeur_sexe.TabIndex = 51
        Me.valeur_sexe.Text = "NOM :"
        '
        'valeur_prenom
        '
        Me.valeur_prenom.AutoSize = True
        Me.valeur_prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_prenom.Location = New System.Drawing.Point(262, 113)
        Me.valeur_prenom.Name = "valeur_prenom"
        Me.valeur_prenom.Size = New System.Drawing.Size(53, 20)
        Me.valeur_prenom.TabIndex = 50
        Me.valeur_prenom.Text = "NOM :"
        '
        'valeur_nom
        '
        Me.valeur_nom.AutoSize = True
        Me.valeur_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_nom.Location = New System.Drawing.Point(262, 75)
        Me.valeur_nom.Name = "valeur_nom"
        Me.valeur_nom.Size = New System.Drawing.Size(53, 20)
        Me.valeur_nom.TabIndex = 49
        Me.valeur_nom.Text = "NOM :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(460, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "NUM :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "PRENOM :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "SEXE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "DATE DE NAISSANCE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "LIEU DE NAISSANCE :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(231, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 42)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "BULLETIN"
        '
        'nom_
        '
        Me.nom_.AutoSize = True
        Me.nom_.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_.Location = New System.Drawing.Point(61, 75)
        Me.nom_.Name = "nom_"
        Me.nom_.Size = New System.Drawing.Size(53, 20)
        Me.nom_.TabIndex = 42
        Me.nom_.Text = "NOM :"
        '
        'Tableau_bulletin
        '
        Me.Tableau_bulletin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tableau_bulletin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tableau_bulletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tableau_bulletin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_matiere, Me.col_coef, Me.col_moy, Me.col_moy_coef, Me.num_etu})
        Me.Tableau_bulletin.Location = New System.Drawing.Point(46, 276)
        Me.Tableau_bulletin.Name = "Tableau_bulletin"
        Me.Tableau_bulletin.Size = New System.Drawing.Size(638, 255)
        Me.Tableau_bulletin.TabIndex = 57
        '
        'col_matiere
        '
        Me.col_matiere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_matiere.HeaderText = "MATIERE"
        Me.col_matiere.Name = "col_matiere"
        '
        'col_coef
        '
        Me.col_coef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_coef.HeaderText = "COEF"
        Me.col_coef.Name = "col_coef"
        '
        'col_moy
        '
        Me.col_moy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_moy.HeaderText = "MOYENNE"
        Me.col_moy.Name = "col_moy"
        '
        'col_moy_coef
        '
        Me.col_moy_coef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_moy_coef.HeaderText = "MOY. COEF"
        Me.col_moy_coef.Name = "col_moy_coef"
        '
        'num_etu
        '
        Me.num_etu.HeaderText = "ID"
        Me.num_etu.Name = "num_etu"
        Me.num_etu.Visible = False
        '
        'valeur_moy
        '
        Me.valeur_moy.AutoSize = True
        Me.valeur_moy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_moy.Location = New System.Drawing.Point(547, 151)
        Me.valeur_moy.Name = "valeur_moy"
        Me.valeur_moy.Size = New System.Drawing.Size(53, 20)
        Me.valeur_moy.TabIndex = 59
        Me.valeur_moy.Text = "NOM :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(460, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "MOY. :"
        '
        'valeur_rang
        '
        Me.valeur_rang.AutoSize = True
        Me.valeur_rang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur_rang.Location = New System.Drawing.Point(547, 186)
        Me.valeur_rang.Name = "valeur_rang"
        Me.valeur_rang.Size = New System.Drawing.Size(53, 20)
        Me.valeur_rang.TabIndex = 61
        Me.valeur_rang.Text = "NOM :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(460, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 20)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "RANG :"
        '
        'Btn_print
        '
        Me.Btn_print.Location = New System.Drawing.Point(464, 220)
        Me.Btn_print.Name = "Btn_print"
        Me.Btn_print.Size = New System.Drawing.Size(131, 23)
        Me.Btn_print.TabIndex = 62
        Me.Btn_print.Text = "IMPRIMER"
        Me.Btn_print.UseVisualStyleBackColor = True
        '
        'BulletinIndividuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 543)
        Me.Controls.Add(Me.Btn_print)
        Me.Controls.Add(Me.valeur_rang)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.valeur_moy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tableau_bulletin)
        Me.Controls.Add(Me.valeur_classe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.valeur_num_matr)
        Me.Controls.Add(Me.valeur_lieu)
        Me.Controls.Add(Me.valeur_date)
        Me.Controls.Add(Me.valeur_sexe)
        Me.Controls.Add(Me.valeur_prenom)
        Me.Controls.Add(Me.valeur_nom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nom_)
        Me.Name = "BulletinIndividuel"
        Me.Text = "Bulletin"
        CType(Me.Tableau_bulletin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents valeur_classe As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents valeur_num_matr As Label
    Friend WithEvents valeur_lieu As Label
    Friend WithEvents valeur_date As Label
    Friend WithEvents valeur_sexe As Label
    Friend WithEvents valeur_prenom As Label
    Friend WithEvents valeur_nom As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nom_ As Label
    Friend WithEvents Tableau_bulletin As DataGridView
    Friend WithEvents col_matiere As DataGridViewTextBoxColumn
    Friend WithEvents col_coef As DataGridViewTextBoxColumn
    Friend WithEvents col_moy As DataGridViewTextBoxColumn
    Friend WithEvents col_moy_coef As DataGridViewTextBoxColumn
    Friend WithEvents num_etu As DataGridViewTextBoxColumn
    Friend WithEvents valeur_moy As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents valeur_rang As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_print As Button
End Class
