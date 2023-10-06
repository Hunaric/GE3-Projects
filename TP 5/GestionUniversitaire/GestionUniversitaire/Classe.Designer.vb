<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classe
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
        Me.Btn_ajout_classe = New System.Windows.Forms.Button()
        Me.Tableau_classe = New System.Windows.Forms.DataGridView()
        Me.nom_classe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_classe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.classe_champs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Tableau_classe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_supp
        '
        Me.Btn_supp.Location = New System.Drawing.Point(421, 210)
        Me.Btn_supp.Name = "Btn_supp"
        Me.Btn_supp.Size = New System.Drawing.Size(83, 23)
        Me.Btn_supp.TabIndex = 52
        Me.Btn_supp.Text = "SUPPRIMER"
        Me.Btn_supp.UseVisualStyleBackColor = True
        '
        'Btn_selection
        '
        Me.Btn_selection.Location = New System.Drawing.Point(421, 166)
        Me.Btn_selection.Name = "Btn_selection"
        Me.Btn_selection.Size = New System.Drawing.Size(84, 23)
        Me.Btn_selection.TabIndex = 51
        Me.Btn_selection.Text = "CHOISIR"
        Me.Btn_selection.UseVisualStyleBackColor = True
        '
        'Btn_ajout_classe
        '
        Me.Btn_ajout_classe.Location = New System.Drawing.Point(421, 98)
        Me.Btn_ajout_classe.Name = "Btn_ajout_classe"
        Me.Btn_ajout_classe.Size = New System.Drawing.Size(83, 23)
        Me.Btn_ajout_classe.TabIndex = 50
        Me.Btn_ajout_classe.Text = "AJOUTER"
        Me.Btn_ajout_classe.UseVisualStyleBackColor = True
        '
        'Tableau_classe
        '
        Me.Tableau_classe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Tableau_classe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tableau_classe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom_classe, Me.num_classe})
        Me.Tableau_classe.Location = New System.Drawing.Point(68, 166)
        Me.Tableau_classe.Name = "Tableau_classe"
        Me.Tableau_classe.Size = New System.Drawing.Size(310, 150)
        Me.Tableau_classe.TabIndex = 49
        '
        'nom_classe
        '
        Me.nom_classe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nom_classe.HeaderText = "CLASSE"
        Me.nom_classe.Name = "nom_classe"
        '
        'num_classe
        '
        Me.num_classe.HeaderText = "Num_classe"
        Me.num_classe.Name = "num_classe"
        Me.num_classe.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 42)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "CLASSE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(193, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 26)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Dans le cas d'une modification, veuillez sélection une" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "classe avant de le rectif" &
    "ier dans le champs de saisie"
        '
        'classe_champs
        '
        Me.classe_champs.Location = New System.Drawing.Point(167, 100)
        Me.classe_champs.Name = "classe_champs"
        Me.classe_champs.Size = New System.Drawing.Size(140, 20)
        Me.classe_champs.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "CLASSE :"
        '
        'Classe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 401)
        Me.Controls.Add(Me.Btn_supp)
        Me.Controls.Add(Me.Btn_selection)
        Me.Controls.Add(Me.Btn_ajout_classe)
        Me.Controls.Add(Me.Tableau_classe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.classe_champs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Classe"
        Me.Text = "Classe"
        CType(Me.Tableau_classe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_supp As Button
    Friend WithEvents Btn_selection As Button
    Friend WithEvents Btn_ajout_classe As Button
    Friend WithEvents Tableau_classe As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents classe_champs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nom_classe As DataGridViewTextBoxColumn
    Friend WithEvents num_classe As DataGridViewTextBoxColumn
End Class
