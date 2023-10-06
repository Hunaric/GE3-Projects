<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matiere
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
        Me.Btn_supp = New System.Windows.Forms.Button()
        Me.Btn_selection = New System.Windows.Forms.Button()
        Me.Btn_ajout_matiere = New System.Windows.Forms.Button()
        Me.Tableau_matiere = New System.Windows.Forms.DataGridView()
        Me.nom_matiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coef_matiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_matiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_matiere_champs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.coef_matiere_champs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Tableau_matiere, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_supp
        '
        Me.Btn_supp.Location = New System.Drawing.Point(371, 238)
        Me.Btn_supp.Name = "Btn_supp"
        Me.Btn_supp.Size = New System.Drawing.Size(91, 23)
        Me.Btn_supp.TabIndex = 41
        Me.Btn_supp.Text = "SUPPRIMER"
        Me.Btn_supp.UseVisualStyleBackColor = True
        '
        'Btn_selection
        '
        Me.Btn_selection.Location = New System.Drawing.Point(371, 191)
        Me.Btn_selection.Name = "Btn_selection"
        Me.Btn_selection.Size = New System.Drawing.Size(91, 23)
        Me.Btn_selection.TabIndex = 40
        Me.Btn_selection.Text = "CHOISIR"
        Me.Btn_selection.UseVisualStyleBackColor = True
        '
        'Btn_ajout_matiere
        '
        Me.Btn_ajout_matiere.Location = New System.Drawing.Point(371, 140)
        Me.Btn_ajout_matiere.Name = "Btn_ajout_matiere"
        Me.Btn_ajout_matiere.Size = New System.Drawing.Size(91, 23)
        Me.Btn_ajout_matiere.TabIndex = 39
        Me.Btn_ajout_matiere.Text = "AJOUTER"
        Me.Btn_ajout_matiere.UseVisualStyleBackColor = True
        '
        'Tableau_matiere
        '
        Me.Tableau_matiere.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Tableau_matiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tableau_matiere.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom_matiere, Me.coef_matiere, Me.num_matiere})
        Me.Tableau_matiere.Location = New System.Drawing.Point(18, 191)
        Me.Tableau_matiere.Name = "Tableau_matiere"
        Me.Tableau_matiere.Size = New System.Drawing.Size(310, 150)
        Me.Tableau_matiere.TabIndex = 38
        '
        'nom_matiere
        '
        Me.nom_matiere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nom_matiere.HeaderText = "NOM MATIERE"
        Me.nom_matiere.Name = "nom_matiere"
        '
        'coef_matiere
        '
        Me.coef_matiere.HeaderText = "COEF"
        Me.coef_matiere.Name = "coef_matiere"
        '
        'num_matiere
        '
        Me.num_matiere.HeaderText = "Num_matiere"
        Me.num_matiere.Name = "num_matiere"
        Me.num_matiere.Visible = False
        '
        'nom_matiere_champs
        '
        Me.nom_matiere_champs.Location = New System.Drawing.Point(143, 95)
        Me.nom_matiere_champs.Name = "nom_matiere_champs"
        Me.nom_matiere_champs.Size = New System.Drawing.Size(140, 20)
        Me.nom_matiere_champs.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "NOM MATIERE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 42)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "MATIERE"
        '
        'coef_matiere_champs
        '
        Me.coef_matiere_champs.Location = New System.Drawing.Point(143, 142)
        Me.coef_matiere_champs.Name = "coef_matiere_champs"
        Me.coef_matiere_champs.Size = New System.Drawing.Size(140, 20)
        Me.coef_matiere_champs.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "COEF MATIERE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 26)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Dans le cas d'une modification, veuillez sélection une " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "matière avant de le rect" &
    "ifier dans le champs de saisie"
        '
        'Matiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 422)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.coef_matiere_champs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_supp)
        Me.Controls.Add(Me.Btn_selection)
        Me.Controls.Add(Me.Btn_ajout_matiere)
        Me.Controls.Add(Me.Tableau_matiere)
        Me.Controls.Add(Me.nom_matiere_champs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Matiere"
        Me.Text = "Matiere"
        CType(Me.Tableau_matiere, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_supp As Button
    Friend WithEvents Btn_selection As Button
    Friend WithEvents Btn_ajout_matiere As Button
    Friend WithEvents Tableau_matiere As DataGridView
    Friend WithEvents nom_matiere_champs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents coef_matiere_champs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nom_matiere As DataGridViewTextBoxColumn
    Friend WithEvents coef_matiere As DataGridViewTextBoxColumn
    Friend WithEvents num_matiere As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
End Class
