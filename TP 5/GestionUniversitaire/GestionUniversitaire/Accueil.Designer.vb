<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.valeur_sexe = New System.Windows.Forms.Label()
        Me.sexe_eleve_search = New System.Windows.Forms.Label()
        Me.empty_search = New System.Windows.Forms.Label()
        Me.valeur_classe = New System.Windows.Forms.Label()
        Me.valeur_matricule = New System.Windows.Forms.Label()
        Me.valeur_date = New System.Windows.Forms.Label()
        Me.valeur_prenom = New System.Windows.Forms.Label()
        Me.valeur_nom = New System.Windows.Forms.Label()
        Me.Btn_bulletin_eleve = New System.Windows.Forms.Button()
        Me.classe_eleve_search = New System.Windows.Forms.Label()
        Me.num_matr_eleve_search = New System.Windows.Forms.Label()
        Me.date_eleve_search = New System.Windows.Forms.Label()
        Me.prenom_eleve_search = New System.Windows.Forms.Label()
        Me.nom_eleve_search = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.champs_rech = New System.Windows.Forms.TextBox()
        Me.Btn_search_matricul = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_classe = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_matiere = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_save_type_note = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Btn_show_bulletin_etu = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btn_show_bulletin_class = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Btn_add_note = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Btn_show_list_etu = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Btn_add_etu = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(807, 462)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.valeur_sexe)
        Me.TabPage1.Controls.Add(Me.sexe_eleve_search)
        Me.TabPage1.Controls.Add(Me.empty_search)
        Me.TabPage1.Controls.Add(Me.valeur_classe)
        Me.TabPage1.Controls.Add(Me.valeur_matricule)
        Me.TabPage1.Controls.Add(Me.valeur_date)
        Me.TabPage1.Controls.Add(Me.valeur_prenom)
        Me.TabPage1.Controls.Add(Me.valeur_nom)
        Me.TabPage1.Controls.Add(Me.Btn_bulletin_eleve)
        Me.TabPage1.Controls.Add(Me.classe_eleve_search)
        Me.TabPage1.Controls.Add(Me.num_matr_eleve_search)
        Me.TabPage1.Controls.Add(Me.date_eleve_search)
        Me.TabPage1.Controls.Add(Me.prenom_eleve_search)
        Me.TabPage1.Controls.Add(Me.nom_eleve_search)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.champs_rech)
        Me.TabPage1.Controls.Add(Me.Btn_search_matricul)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(799, 436)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Accueil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'valeur_sexe
        '
        Me.valeur_sexe.AutoSize = True
        Me.valeur_sexe.Location = New System.Drawing.Point(480, 251)
        Me.valeur_sexe.Name = "valeur_sexe"
        Me.valeur_sexe.Size = New System.Drawing.Size(38, 13)
        Me.valeur_sexe.TabIndex = 44
        Me.valeur_sexe.Text = "NOM :"
        Me.valeur_sexe.Visible = False
        '
        'sexe_eleve_search
        '
        Me.sexe_eleve_search.AutoSize = True
        Me.sexe_eleve_search.Location = New System.Drawing.Point(359, 251)
        Me.sexe_eleve_search.Name = "sexe_eleve_search"
        Me.sexe_eleve_search.Size = New System.Drawing.Size(41, 13)
        Me.sexe_eleve_search.TabIndex = 43
        Me.sexe_eleve_search.Text = "SEXE :"
        Me.sexe_eleve_search.Visible = False
        '
        'empty_search
        '
        Me.empty_search.AutoSize = True
        Me.empty_search.Location = New System.Drawing.Point(29, 235)
        Me.empty_search.Name = "empty_search"
        Me.empty_search.Size = New System.Drawing.Size(130, 13)
        Me.empty_search.TabIndex = 42
        Me.empty_search.Text = "NUMERO NON TROUVE"
        Me.empty_search.Visible = False
        '
        'valeur_classe
        '
        Me.valeur_classe.AutoSize = True
        Me.valeur_classe.Location = New System.Drawing.Point(480, 222)
        Me.valeur_classe.Name = "valeur_classe"
        Me.valeur_classe.Size = New System.Drawing.Size(38, 13)
        Me.valeur_classe.TabIndex = 41
        Me.valeur_classe.Text = "NOM :"
        Me.valeur_classe.Visible = False
        '
        'valeur_matricule
        '
        Me.valeur_matricule.AutoSize = True
        Me.valeur_matricule.Location = New System.Drawing.Point(480, 192)
        Me.valeur_matricule.Name = "valeur_matricule"
        Me.valeur_matricule.Size = New System.Drawing.Size(38, 13)
        Me.valeur_matricule.TabIndex = 40
        Me.valeur_matricule.Text = "NOM :"
        Me.valeur_matricule.Visible = False
        '
        'valeur_date
        '
        Me.valeur_date.AutoSize = True
        Me.valeur_date.Location = New System.Drawing.Point(480, 161)
        Me.valeur_date.Name = "valeur_date"
        Me.valeur_date.Size = New System.Drawing.Size(38, 13)
        Me.valeur_date.TabIndex = 39
        Me.valeur_date.Text = "NOM :"
        Me.valeur_date.Visible = False
        '
        'valeur_prenom
        '
        Me.valeur_prenom.AutoSize = True
        Me.valeur_prenom.Location = New System.Drawing.Point(480, 129)
        Me.valeur_prenom.Name = "valeur_prenom"
        Me.valeur_prenom.Size = New System.Drawing.Size(38, 13)
        Me.valeur_prenom.TabIndex = 38
        Me.valeur_prenom.Text = "NOM :"
        Me.valeur_prenom.Visible = False
        '
        'valeur_nom
        '
        Me.valeur_nom.AutoSize = True
        Me.valeur_nom.Location = New System.Drawing.Point(480, 100)
        Me.valeur_nom.Name = "valeur_nom"
        Me.valeur_nom.Size = New System.Drawing.Size(38, 13)
        Me.valeur_nom.TabIndex = 37
        Me.valeur_nom.Text = "NOM :"
        Me.valeur_nom.Visible = False
        '
        'Btn_bulletin_eleve
        '
        Me.Btn_bulletin_eleve.Location = New System.Drawing.Point(397, 287)
        Me.Btn_bulletin_eleve.Name = "Btn_bulletin_eleve"
        Me.Btn_bulletin_eleve.Size = New System.Drawing.Size(207, 23)
        Me.Btn_bulletin_eleve.TabIndex = 36
        Me.Btn_bulletin_eleve.Text = "AFFICHER LE BULLETIN"
        Me.Btn_bulletin_eleve.UseVisualStyleBackColor = True
        Me.Btn_bulletin_eleve.Visible = False
        '
        'classe_eleve_search
        '
        Me.classe_eleve_search.AutoSize = True
        Me.classe_eleve_search.Location = New System.Drawing.Point(359, 222)
        Me.classe_eleve_search.Name = "classe_eleve_search"
        Me.classe_eleve_search.Size = New System.Drawing.Size(54, 13)
        Me.classe_eleve_search.TabIndex = 35
        Me.classe_eleve_search.Text = "CLASSE :"
        Me.classe_eleve_search.Visible = False
        '
        'num_matr_eleve_search
        '
        Me.num_matr_eleve_search.AutoSize = True
        Me.num_matr_eleve_search.Location = New System.Drawing.Point(359, 192)
        Me.num_matr_eleve_search.Name = "num_matr_eleve_search"
        Me.num_matr_eleve_search.Size = New System.Drawing.Size(75, 13)
        Me.num_matr_eleve_search.TabIndex = 34
        Me.num_matr_eleve_search.Text = "MATRICULE :"
        Me.num_matr_eleve_search.Visible = False
        '
        'date_eleve_search
        '
        Me.date_eleve_search.AutoSize = True
        Me.date_eleve_search.Location = New System.Drawing.Point(359, 161)
        Me.date_eleve_search.Name = "date_eleve_search"
        Me.date_eleve_search.Size = New System.Drawing.Size(106, 13)
        Me.date_eleve_search.TabIndex = 33
        Me.date_eleve_search.Text = "DATE NAISSANCE :"
        Me.date_eleve_search.Visible = False
        '
        'prenom_eleve_search
        '
        Me.prenom_eleve_search.AutoSize = True
        Me.prenom_eleve_search.Location = New System.Drawing.Point(359, 129)
        Me.prenom_eleve_search.Name = "prenom_eleve_search"
        Me.prenom_eleve_search.Size = New System.Drawing.Size(60, 13)
        Me.prenom_eleve_search.TabIndex = 32
        Me.prenom_eleve_search.Text = "PRENOM :"
        Me.prenom_eleve_search.Visible = False
        '
        'nom_eleve_search
        '
        Me.nom_eleve_search.AutoSize = True
        Me.nom_eleve_search.Location = New System.Drawing.Point(359, 100)
        Me.nom_eleve_search.Name = "nom_eleve_search"
        Me.nom_eleve_search.Size = New System.Drawing.Size(38, 13)
        Me.nom_eleve_search.TabIndex = 31
        Me.nom_eleve_search.Text = "NOM :"
        Me.nom_eleve_search.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "RECHERCHER UN NUMERO MATRICUL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "---------------------------------------------------------"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 42)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "ACCUEIL"
        '
        'champs_rech
        '
        Me.champs_rech.Location = New System.Drawing.Point(32, 126)
        Me.champs_rech.Name = "champs_rech"
        Me.champs_rech.Size = New System.Drawing.Size(207, 20)
        Me.champs_rech.TabIndex = 1
        '
        'Btn_search_matricul
        '
        Me.Btn_search_matricul.Location = New System.Drawing.Point(32, 161)
        Me.Btn_search_matricul.Name = "Btn_search_matricul"
        Me.Btn_search_matricul.Size = New System.Drawing.Size(207, 23)
        Me.Btn_search_matricul.TabIndex = 0
        Me.Btn_search_matricul.Text = "RECHERCHER"
        Me.Btn_search_matricul.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Btn_classe)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Btn_matiere)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Btn_save_type_note)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(799, 436)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Administration"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(536, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "ENREGISTRER UNE CLASSE"
        '
        'Btn_classe
        '
        Me.Btn_classe.Location = New System.Drawing.Point(539, 128)
        Me.Btn_classe.Name = "Btn_classe"
        Me.Btn_classe.Size = New System.Drawing.Size(152, 23)
        Me.Btn_classe.TabIndex = 32
        Me.Btn_classe.Text = "CLASSE"
        Me.Btn_classe.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(295, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "ENREGISTRER UNE MATIERE"
        '
        'Btn_matiere
        '
        Me.Btn_matiere.Location = New System.Drawing.Point(298, 128)
        Me.Btn_matiere.Name = "Btn_matiere"
        Me.Btn_matiere.Size = New System.Drawing.Size(159, 23)
        Me.Btn_matiere.TabIndex = 30
        Me.Btn_matiere.Text = "MATIERE"
        Me.Btn_matiere.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ENREGISTRER UN TYPE DE NOTE"
        '
        'Btn_save_type_note
        '
        Me.Btn_save_type_note.Location = New System.Drawing.Point(33, 128)
        Me.Btn_save_type_note.Name = "Btn_save_type_note"
        Me.Btn_save_type_note.Size = New System.Drawing.Size(183, 23)
        Me.Btn_save_type_note.TabIndex = 28
        Me.Btn_save_type_note.Text = "TYPE DE NOTE"
        Me.Btn_save_type_note.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 42)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "ADMINISTRER"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.ComboBox2)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Btn_show_bulletin_etu)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Btn_show_bulletin_class)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(799, 436)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bulletin"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(451, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(223, 52)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "NB : Veuillez choisir une classe au préalable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        sans cliquer le bouton ""AF" &
    "FICHER PAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        CLASSE"" avant de pouvoir sélectionner " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        un etidiant"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(451, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(215, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "CHOISIR UN ETUDIANT ----------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(454, 142)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox2.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(451, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(217, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "AFFICHER LE BULLETIN D'UN ETUDIANT"
        '
        'Btn_show_bulletin_etu
        '
        Me.Btn_show_bulletin_etu.Location = New System.Drawing.Point(454, 190)
        Me.Btn_show_bulletin_etu.Name = "Btn_show_bulletin_etu"
        Me.Btn_show_bulletin_etu.Size = New System.Drawing.Size(212, 23)
        Me.Btn_show_bulletin_etu.TabIndex = 34
        Me.Btn_show_bulletin_etu.Text = "AFFICHER"
        Me.Btn_show_bulletin_etu.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(217, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "CHOISIR UNE CLASSE -------------------------------"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(42, 145)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox1.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "AFFICHER LES MOYENNES PAR CLASSE"
        '
        'Btn_show_bulletin_class
        '
        Me.Btn_show_bulletin_class.Location = New System.Drawing.Point(42, 193)
        Me.Btn_show_bulletin_class.Name = "Btn_show_bulletin_class"
        Me.Btn_show_bulletin_class.Size = New System.Drawing.Size(212, 23)
        Me.Btn_show_bulletin_class.TabIndex = 30
        Me.Btn_show_bulletin_class.Text = "AFFICHER PAR CLASSE"
        Me.Btn_show_bulletin_class.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 42)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "BULLETIN"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.ComboBox3)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Btn_add_note)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(799, 436)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Note"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(61, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(217, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "CHOISIR UNE CLASSE -------------------------------"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(64, 167)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(212, 21)
        Me.ComboBox3.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(61, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(220, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "AJOUTER UNE NOTE POUR UNE CLASSE"
        '
        'Btn_add_note
        '
        Me.Btn_add_note.Location = New System.Drawing.Point(64, 215)
        Me.Btn_add_note.Name = "Btn_add_note"
        Me.Btn_add_note.Size = New System.Drawing.Size(212, 23)
        Me.Btn_add_note.TabIndex = 34
        Me.Btn_add_note.Text = "AJOUTER"
        Me.Btn_add_note.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(290, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 42)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "NOTE"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.ComboBox4)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Controls.Add(Me.Btn_show_list_etu)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.Btn_add_etu)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(799, 436)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Etudiant"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(375, 149)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(196, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "CHOISIR UNE CLASSE ------------------------"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(378, 186)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(193, 21)
        Me.ComboBox4.TabIndex = 40
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(375, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(196, 13)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "LISTE DES ETUDIANTS PAR CLASSE"
        '
        'Btn_show_list_etu
        '
        Me.Btn_show_list_etu.Location = New System.Drawing.Point(378, 234)
        Me.Btn_show_list_etu.Name = "Btn_show_list_etu"
        Me.Btn_show_list_etu.Size = New System.Drawing.Size(193, 23)
        Me.Btn_show_list_etu.TabIndex = 38
        Me.Btn_show_list_etu.Text = "AFFICHER"
        Me.Btn_show_list_etu.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(65, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "AJOUTER UN ETUDIANT"
        '
        'Btn_add_etu
        '
        Me.Btn_add_etu.Location = New System.Drawing.Point(68, 143)
        Me.Btn_add_etu.Name = "Btn_add_etu"
        Me.Btn_add_etu.Size = New System.Drawing.Size(131, 23)
        Me.Btn_add_etu.TabIndex = 30
        Me.Btn_add_etu.Text = "AJOUTER"
        Me.Btn_add_etu.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 42)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ETUDIANT"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 457)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Accueil"
        Me.Text = "GESTION UNIVERSITAIRE"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents champs_rech As TextBox
    Friend WithEvents Btn_search_matricul As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_save_type_note As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Btn_classe As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_matiere As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Btn_show_bulletin_etu As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_show_bulletin_class As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Btn_add_note As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Btn_add_etu As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Btn_show_list_etu As Button
    Friend WithEvents num_matr_eleve_search As Label
    Friend WithEvents date_eleve_search As Label
    Friend WithEvents prenom_eleve_search As Label
    Friend WithEvents nom_eleve_search As Label
    Friend WithEvents Btn_bulletin_eleve As Button
    Friend WithEvents classe_eleve_search As Label
    Friend WithEvents valeur_prenom As Label
    Friend WithEvents valeur_nom As Label
    Friend WithEvents valeur_matricule As Label
    Friend WithEvents valeur_date As Label
    Friend WithEvents valeur_classe As Label
    Friend WithEvents empty_search As Label
    Friend WithEvents valeur_sexe As Label
    Friend WithEvents sexe_eleve_search As Label
End Class
