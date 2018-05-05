using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Chambres
{
    public partial class BR_Chambres : Bate_s_Reservation_Base_Biblioteque.BR_Biblio
    {
        private DataRow BR_dataRow_Chambre;
        private bool linkGrid = false;
        private bool abandon = true;

        public BR_Chambres()
        {
            InitializeComponent();
            ActiveControle_S(false, false, false, false, false, false);
        }
        private void BR_Chambres_Load(object sender, EventArgs e)
        {
            Fill();
            LinkChambres();
            abandon = false;
            ActiveControl_TB(false, false, false, false, false, false, false, false);
            Visible_LS(true, false, false, false);
            Visible_B_ADD(false, false);
            Visible_LS_Label(false, false, false, false);
            //TA_ach.Fill(ds_Ach.ACH);
        }

        private void Fill()
        {
            this.BR_TA_Chambres.FillBy(this.BR_DS_Chambres.chambre);
            this.BR_TA_Chambres_Ayant.Fill(this.BR_DS_Chambres.ayant);
        }
        private void LinkChambres()
        {
            this.BR_BS_Chambres.DataMember = "chambre";
            this.BR_BS_Chambres.DataSource = this.BR_DS_Chambres;
            this.BR_BS_Chambres_Ayant.DataSource = this.BR_BS_Chambres;
            this.BR_BS_Chambres_Ayant.DataMember = "FK__ayant__Nocham__64D7DFA6";

            Link();
        }
        private void Link()
        {
            if (linkGrid == false)
            {
                BR_DGV_Chambres.DataSource = BR_BS_Chambres_Ayant;
                try
                {
                    BR_TB_Chambre_NoCham.DataBindings.Add("Text", BR_BS_Chambres, "NoCham");
                    BR_TB_Chambre_Etage.DataBindings.Add("Text", BR_BS_Chambres, "Etage");
                    BR_TB_Chambres_Prix.DataBindings.Add("Text", BR_BS_Chambres, "Prix");

                    BR_TB_Chambres_Etat.DataBindings.Add("Text", BR_BS_Chambres, "Etat");
                    BR_TB_Chambre_CodeType.DataBindings.Add("Text", BR_BS_Chambres, "CodTypCham");
                    BR_TB_Chambre_CodeLoc.DataBindings.Add("Text", BR_BS_Chambres, "CodLoc");
                    BR_TB_Chambre_Desc1.DataBindings.Add("Text", BR_BS_Chambres, "DescTyp");
                    BR_TB_Chambre_Desc2.DataBindings.Add("Text", BR_BS_Chambres, "DescLoc");

                    linkGrid = true;
                }
                catch
                {
                    throw;
                }
            }
        }
        public bool IsNumeric(string Nombre)
        {
            try
            {
                int.Parse(Nombre);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void ClearField()
        {
            BR_TB_Chambre_NoCham.Clear();
            BR_TB_Chambre_Etage.Clear();
            BR_TB_Chambres_Prix.Clear();

            BR_TB_Chambres_Etat.Clear();
            BR_TB_Chambre_CodeType.Clear();
            BR_TB_Chambre_CodeLoc.Clear();
            BR_TB_Chambre_Desc1.Clear();
            BR_TB_Chambre_Desc2.Clear();
        }
        private void ClearError()
        {
            BR_EP.SetError(BR_TB_Chambre_NoCham, "");
            BR_EP.SetError(BR_TB_Chambre_CodeType, "");
            BR_EP.SetError(BR_TB_Chambre_Desc1, "");
            BR_EP.SetError(BR_TB_Chambre_CodeLoc, "");
            BR_EP.SetError(BR_TB_Chambre_Desc2, "");

            BR_EP.SetError(BR_TB_Chambres_Etat, "");
            BR_EP.SetError(BR_TB_Chambres_Prix, "");

            BR_TB_Chambre_NoCham.BackColor = Color.Empty;
            BR_TB_Chambre_Etage.BackColor = Color.Empty;
            BR_TB_Chambres_Prix.BackColor = Color.Empty;

            BR_TB_Chambres_Etat.BackColor = Color.Empty;
            BR_TB_Chambre_CodeType.BackColor = Color.Empty;
            BR_TB_Chambre_CodeLoc.BackColor = Color.Empty;
            BR_TB_Chambre_Desc1.BackColor = Color.Empty;
            BR_TB_Chambre_Desc2.BackColor = Color.Empty;
        }
        private void UnLink()
        {
            BR_DGV_Chambres.DataSource = null;
            BR_TB_Chambre_NoCham.DataBindings.Clear();
            BR_TB_Chambre_Etage.DataBindings.Clear();
            BR_TB_Chambres_Prix.DataBindings.Clear();

            BR_TB_Chambres_Etat.DataBindings.Clear();
            BR_TB_Chambre_CodeType.DataBindings.Clear();
            BR_TB_Chambre_CodeLoc.DataBindings.Clear();
            BR_TB_Chambre_Desc1.DataBindings.Clear();
            BR_TB_Chambre_Desc2.DataBindings.Clear();

            linkGrid = false;
        }

        private void CreateChamber()
        {
            BR_dataRow_Chambre = BR_DS_Chambres.Tables["chambre"].NewRow();
            BR_dataRow_Chambre["NoCham"] = BR_TB_Chambre_NoCham.Text;
            BR_DS_Chambres.Tables["chambre"].Rows.Add(BR_dataRow_Chambre);
            BR_BS_Chambres.Position = BR_BS_Chambres.Count - 1;
            Link();

            ///AJOUT AUTOMATIQUE DE L'ETAGE A LA CHAMBRE
            char tokens = BR_TB_Chambre_NoCham.Text[0];
            BR_TB_Chambre_Etage.Text = tokens.ToString();
            ///AJOUT AUTOMATIQUE DE L'ETAGE A LA CHAMBRE
            
            ActiveControl_TB(false, false, true, false, true, false, true, true);

            BR_TB_Chambre_NoCham.Focus();
        }

        #region ActiveControl
        private void ActiveControl_TB(bool TB_NoCham, bool TB_Etage, bool TB_CodeType, bool TB_Desc1, bool TB_CodeLoc, bool TB_Desc2, bool TB_Prix, bool TB_Etat)
        {
            BR_TB_Chambre_NoCham.Enabled = TB_NoCham;
            BR_TB_Chambre_Etage.Enabled = TB_Etage;
            BR_TB_Chambre_CodeType.Enabled = TB_CodeType;
            BR_TB_Chambre_Desc1.Enabled = TB_Desc1;
            BR_TB_Chambre_CodeLoc.Enabled = TB_CodeLoc;
            BR_TB_Chambre_Desc2.Enabled = TB_Desc2;
            BR_TB_Chambres_Prix.Enabled = TB_Prix;
            BR_TB_Chambres_Etat.Enabled = TB_Etat;
        }

        private void ActiveControle_G(bool B_Add_G, bool B_Edit_G, bool B_Undo_G, bool B_Save_G, bool B_Del_G, bool B_View_G, bool B_List_G, bool B_Gotofirst_G, bool B_Previous_G, bool B_Next_G, bool B_Gotoend_G)
        {
            BR_Button_Add_G.Enabled = B_Add_G;
            BR_Button_Edit_G.Enabled = B_Edit_G;
            BR_Button_Undo_G.Enabled = B_Undo_G;
            BR_Button_Save_G.Enabled = B_Save_G;
            BR_Button_Del_G.Enabled = B_Del_G;
            BR_Button_View_G.Enabled = B_View_G;
            BR_Button_List_G.Enabled = B_List_G;

            BR_Button_Gotofirst_G.Enabled = B_Gotofirst_G;
            BR_Button_Previous_G.Enabled = B_Previous_G;
            BR_Button_Next_G.Enabled = B_Next_G;
            BR_Button_Gotoend_G.Enabled = B_Gotoend_G;
        }
        private void VisibleControle_G(bool B_Add_G, bool B_Edit_G, bool B_Undo_G, bool B_Save_G, bool B_Del_G, bool B_View_G, bool B_List_G)
        {
            BR_Button_Add_G.Visible = B_Add_G;
            BR_Button_Edit_G.Visible = B_Edit_G;
            BR_Button_Undo_G.Visible = B_Undo_G;
            BR_Button_Save_G.Visible = B_Save_G;
            BR_Button_Del_G.Visible = B_Del_G;
            BR_Button_View_G.Visible = B_View_G;
            BR_Button_List_G.Visible = B_List_G;
        }

        private void ActiveControle_S(bool B_Add_S, bool B_Edit_S, bool B_Undo_S, bool B_Save_S, bool B_Del_S, bool B_View_S)
        {
            BR_Button_Add_S.Enabled = B_Add_S;
            BR_Button_Edit_S.Enabled = B_Edit_S;
            BR_Button_Undo_S.Enabled = B_Undo_S;
            BR_Button_Save_S.Enabled = B_Save_S;
            BR_Button_Del_S.Enabled = B_Del_S;
            BR_Button_View_S.Enabled = B_View_S;
        }
        private void VisibleControle_S(bool B_Add_S, bool B_Del_S, bool B_View_S, bool B_Undo_S, bool B_Edit_S, bool B_Save_S)
        {
            BR_Button_Add_S.Visible = B_Add_S;
            BR_Button_Edit_S.Visible = B_Edit_S;
            BR_Button_Undo_S.Visible = B_Undo_S;
            BR_Button_Save_S.Visible = B_Save_S;
            BR_Button_Del_S.Visible = B_Del_S;
            BR_Button_View_S.Visible = B_View_S;
        }

        private void Visible_B_ADD(bool BR_B_Add_S, bool BR_B_Del_S)
        {
            BR_Button_AddChamber_S.Visible = BR_B_Add_S;
            BR_Button_DelChamber_S.Visible = BR_B_Del_S;
        }

        private void Visible_LS(bool BR_LS_NoCham, bool BR_LS_CodeType, bool BR_LS_CodeLoc, bool BR_LS_Commodite)
        {
            BR_Button_LS_Chambre_S.Visible = BR_LS_NoCham;
            BR_Button_LS_CodeType_S.Visible = BR_LS_CodeType;
            BR_Button_LS_CodeLoc_S.Visible = BR_LS_CodeLoc;
            BR_Button_LS_CodeCom_S.Visible = BR_LS_Commodite;

        }
        private void Visible_LS_Label(bool BR_LA_NoCham, bool BR_LA_CodeType, bool BR_LA_CodeLoc, bool BR_LA_LS_CodeCom)
        {
            BR_LA_LS_NoCham_S.Visible = BR_LA_NoCham;
            BR_LA_LS_CodeType_S.Visible = BR_LA_CodeType;
            BR_LA_LS_CodeLoc_S.Visible = BR_LA_CodeLoc;
            BR_LA_LS_CodeCom_S.Visible = BR_LA_LS_CodeCom;
        }
        #endregion

        #region ValidationAjoutChambre
        private bool Valide()
        {// on valide les informations autres que la clef primaire
            bool valide = true;
            if (!ValideNom()) valide = false;
            else if (!ValideCodeType()) valide = false;
            else if (!ValideCodeLoc()) valide = false;
            else if (!ValideEtat()) valide = false;
            else if (!ValidePrix()) valide = false;
            return valide;
        }
        private bool ValideNom()
        {
            if (BR_TB_Chambre_NoCham.Text.Length == 0)
            {
                BR_TB_Chambre_NoCham.Focus();
                BR_TB_Chambre_NoCham.BackColor = Color.Red;
                BR_EP.SetError(BR_TB_Chambre_NoCham, "Vueillez entrer un numéro de chambre valide");
                return false;
            }
            // Dtr_Ach["Nom_Ach"] = Cs_Nom_Ach.Text; errorProvider1.SetError(Cs_Nom_Ach, "");
            return true;
        }
        private bool ValideCodeType()
        {
            if (BR_TB_Chambre_CodeType.Text.Length == 0)
            {
                BR_TB_Chambre_CodeType.Focus();
                BR_TB_Chambre_CodeType.BackColor = Color.Red;
                BR_EP.SetError(BR_TB_Chambre_CodeType, "Vueillez entrer un code type chambre valide");
                return false;
            }

            // Dtr_Ach["Nom_Ach"] = Cs_Nom_Ach.Text; errorProvider1.SetError(Cs_Nom_Ach, "");
            return true;
        }
        private bool ValideCodeLoc()
        {
            if (BR_TB_Chambre_CodeLoc.Text.Length == 0)
            {
                BR_TB_Chambre_CodeLoc.Focus();
                BR_TB_Chambre_CodeLoc.BackColor = Color.Red;
                BR_EP.SetError(BR_TB_Chambre_CodeLoc, "Vueillez entrer un code type chambre valide");
                return false;
            }

            // Dtr_Ach["Nom_Ach"] = Cs_Nom_Ach.Text; errorProvider1.SetError(Cs_Nom_Ach, "");
            return true;
        }
        private bool ValideEtat()
        {
            if (BR_TB_Chambres_Etat.Text.Length == 0)
            {
                BR_TB_Chambres_Etat.Focus();
                BR_TB_Chambres_Etat.BackColor = Color.Red;
                BR_EP.SetError(BR_TB_Chambres_Etat, "Vueillez entrer un état de chambre valide");
                return false;
            }

            // Dtr_Ach["Nom_Ach"] = Cs_Nom_Ach.Text; errorProvider1.SetError(Cs_Nom_Ach, "");
            return true;
        }
        private bool ValidePrix()
        {
            if (BR_TB_Chambres_Prix.Text.Length == 0)
            {
                BR_TB_Chambres_Prix.Focus();
                BR_TB_Chambres_Prix.BackColor = Color.Red;
                BR_EP.SetError(BR_TB_Chambres_Prix, "Vueillez entrer un tarif de chambre valide");
                return false;
            }
            // Dtr_Ach["Nom_Ach"] = Cs_Nom_Ach.Text; errorProvider1.SetError(Cs_Nom_Ach, "");
            return true;
        }

        private void BR_TB_Chambre_NoCham_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                int index = BR_BS_Chambres.Find("NoCham", BR_TB_Chambre_NoCham.Text);

                if ((BR_TB_Chambre_NoCham.Text.Length == 0) || (!IsNumeric(BR_TB_Chambre_NoCham.Text)))
                {
                    BR_EP.SetError(BR_TB_Chambre_NoCham, " Veuillez entrer un nombre compris entre 00001 et 99999");

                    BR_TB_Chambre_NoCham.Focus();
                    BR_TB_Chambre_NoCham.BackColor = Color.Red;

                }
                else
                {
                    if (BR_TB_Chambre_NoCham.Text.Length != 3)
                    {
                        BR_EP.SetError(BR_TB_Chambre_NoCham, "Veuillez entrer 3 caractères ");
                        BR_TB_Chambre_NoCham.Focus();
                        BR_TB_Chambre_NoCham.BackColor = Color.Red;

                    }
                    else
                    {
                        if (index < 0)
                        {
                            BR_EP.SetError(BR_TB_Chambre_NoCham, "");
                            BR_TB_Chambre_NoCham.BackColor = Color.LawnGreen;
                            Visible_B_ADD(true, true);
                            Visible_LS(false, false, false, false); // affichage des listes de selection
                            CreateChamber();
                        }
                        else
                        {
                            BR_EP.SetError(BR_TB_Chambre_NoCham, "Ce numéro d'acheteur existe déjà" + index.ToString());

                            BR_TB_Chambre_NoCham.Focus();
                            BR_TB_Chambre_NoCham.BackColor = Color.Red;

                        }
                    }
                }

            }
        }
        private void BR_TB_Chambre_CodeType_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                if (BR_TB_Chambre_CodeType.Text.Length == 0)
                {
                    BR_EP.SetError(BR_TB_Chambre_CodeType, "Veuillez entrer 2 caractères ");
                    BR_TB_Chambre_CodeType.Focus();
                    BR_TB_Chambre_CodeType.BackColor = Color.Red;

                }
                else
                {
                    if (BR_TB_Chambre_CodeType.Text.Length == 2 && (BR_TB_Chambre_CodeType.Text.ToUpper() == "1S" || BR_TB_Chambre_CodeType.Text.ToUpper() == "2S" || BR_TB_Chambre_CodeType.Text == "1D" || BR_TB_Chambre_CodeType.Text.ToUpper() == "2D"))
                    {
                        if (BR_TB_Chambre_CodeType.Text.ToUpper() == "1S")
                        {
                            BR_TB_Chambre_CodeType.Text = "1S";
                            BR_TB_Chambre_Desc1.Text = "un lit simple";
                        }
                        else if (BR_TB_Chambre_CodeType.Text.ToUpper() == "2S")
                        {
                            BR_TB_Chambre_CodeType.Text = "2S";
                            BR_TB_Chambre_Desc1.Text = "deux lits simples";
                        }
                        else if (BR_TB_Chambre_CodeType.Text == "1D")
                        {
                            BR_TB_Chambre_CodeType.Text = "1D";
                            BR_TB_Chambre_Desc1.Text = "un lit double";
                        }
                        else
                        {
                            BR_TB_Chambre_CodeType.Text = "2D";
                            BR_TB_Chambre_Desc1.Text = "deux lits double";
                        }

                        BR_EP.SetError(BR_TB_Chambre_CodeType, "");
                        BR_TB_Chambre_CodeType.BackColor = Color.LawnGreen;

                     
                    }
                    else
                    {
                        BR_EP.SetError(BR_TB_Chambre_CodeType, "Entrer un code valdie " + "for example:  1S, 2S, 1D ou 2D");
                        BR_TB_Chambre_CodeType.Focus();
                        BR_TB_Chambre_CodeType.BackColor = Color.Red;
                    }

                }
            }
        }
        private void BR_TB_Chambre_CodeLoc_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                if (BR_TB_Chambre_CodeLoc.Text.Length == 0)
                {
                    BR_EP.SetError(BR_TB_Chambre_CodeLoc, "Veuillez entrer 2 caractères ");
                    BR_TB_Chambre_CodeLoc.Focus();
                    BR_TB_Chambre_CodeLoc.BackColor = Color.Red;

                }
                else
                {
                    if (BR_TB_Chambre_CodeLoc.Text.Length == 2 && (BR_TB_Chambre_CodeLoc.Text.ToUpper() == "AR" || BR_TB_Chambre_CodeLoc.Text.ToUpper() == "AV" || BR_TB_Chambre_CodeLoc.Text.ToUpper() == "VC"))
                    {
                        if (BR_TB_Chambre_CodeLoc.Text.ToUpper() == "AR")
                        {
                            BR_TB_Chambre_CodeLoc.Text = "AR";
                            BR_TB_Chambre_Desc2.Text = "arriere";
                        }
                        else if (BR_TB_Chambre_CodeLoc.Text.ToUpper() == "AV")
                        {
                            BR_TB_Chambre_CodeLoc.Text = "AV";
                            BR_TB_Chambre_Desc2.Text = "avant";
                        }
                        else
                        {
                            BR_TB_Chambre_CodeLoc.Text = "VC";
                            BR_TB_Chambre_Desc2.Text = "vu sur cimetiere";
                        }

                        BR_EP.SetError(BR_TB_Chambre_CodeLoc, "");
                        BR_TB_Chambre_CodeLoc.BackColor = Color.LawnGreen;
                    }
                    else
                    {
                        BR_EP.SetError(BR_TB_Chambre_CodeLoc, "Entrer un code valdie " + "for example:  AR, AV ou VC");
                        BR_TB_Chambre_CodeLoc.Focus();
                        BR_TB_Chambre_CodeLoc.BackColor = Color.Red;
                    }

                }
            }
        }
        private void BR_TB_Chambres_Etat_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                if (BR_TB_Chambres_Etat.Text.Length == 0)
                {
                    BR_EP.SetError(BR_TB_Chambres_Etat, "Veuillez entrer disponible ou indisponible");
                    BR_TB_Chambres_Etat.Focus();
                    BR_TB_Chambres_Etat.BackColor = Color.Red;

                }
                else
                {
                    if (BR_TB_Chambres_Etat.Text.ToLower() == "disponible" || BR_TB_Chambres_Etat.Text.ToLower() == "non disponible" || BR_TB_Chambres_Etat.Text == "1" || BR_TB_Chambres_Etat.Text == "0")
                    {
                        if (BR_TB_Chambres_Etat.Text.ToLower() == "disponible" || BR_TB_Chambres_Etat.Text == "1")
                        {

                            BR_EP.SetError(BR_TB_Chambres_Etat, "");
                            BR_TB_Chambres_Etat.BackColor = Color.LawnGreen;
                            BR_TB_Chambres_Etat.Text = "1";
                        }
                        else
                        {
                            BR_TB_Chambres_Etat.Text = "0";
                            BR_EP.SetError(BR_TB_Chambres_Etat, "");
                            BR_TB_Chambres_Etat.BackColor = Color.LawnGreen;
                        }

                        BR_EP.SetError(BR_TB_Chambres_Etat, "");
                        BR_TB_Chambres_Etat.BackColor = Color.LawnGreen;
                    }
                    else
                    {
                        BR_EP.SetError(BR_TB_Chambres_Etat, "Entrer disponible ou non disponible ");
                        BR_TB_Chambres_Etat.Focus();
                        BR_TB_Chambres_Etat.BackColor = Color.Red;
                    }
                }
            }
        }
        private void BR_TB_Chambres_Prix_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                if (BR_TB_Chambres_Prix.Text.Length == 0 || (!IsNumeric(BR_TB_Chambres_Prix.Text)))
                {
                    BR_EP.SetError(BR_TB_Chambres_Prix, " Veuillez entrer un nombre compris entre 00001 et 99999");
                    BR_TB_Chambres_Prix.Focus();
                    BR_TB_Chambres_Prix.BackColor = Color.Red;

                }
                else
                {
                    BR_EP.SetError(BR_TB_Chambres_Prix, "");
                    BR_TB_Chambres_Prix.BackColor = Color.LawnGreen;

                }
            }
        }

        private void BR_TB_Chambre_NoCham_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                ValideNom();
        }
        private void BR_TB_Chambre_CodeType_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                ValideCodeType();
        }
        private void BR_TB_Chambre_CodeLoc_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                ValideCodeLoc();
        }
        private void BR_TB_Chambres_Etat_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                ValideEtat();
        }
        private void BR_TB_Chambres_Prix_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                ValidePrix();
        }
        #endregion

        #region Button_S
        private void BR_Button_AddChamber_S_Click(object sender, EventArgs e)
        {
            if (Valide())
            {
                abandon = false;
                Visible_B_ADD(false, false);
                BR_Button_Save_S_Click(this, e);
            }
        }
        private void BR_Button_DelChamber_S_Click(object sender, EventArgs e)
        {
            abandon = true;
            BR_Button_Undo_S_Click(this, e);
            Visible_B_ADD(false, false);
        }

        private void BR_Button_Edit_S_Click(object sender, EventArgs e)
        {
            abandon = false;
            // Dtr_Ach = ds_Ach.Tables["Ach"].Rows[Bs_Ach.Position]; //pour travailler avec dtr au lieu de tout la ligne de code
            // sinon ne prend pas toujours les modifications
            //Dtr_Ach.BeginEdit();
            //Ly_Activer_Boutons(true, true, true, true, true, true, true, true, true, true, true, true, true);
            // pas permettre de modifier la clef primaire
            //Activer_Saisie(false, true, true, true);
        }
        private void BR_Button_Del_S_Click(object sender, EventArgs e)
        {
            abandon = false;
        }
        private void BR_Button_View_S_Click(object sender, EventArgs e)
        {
            abandon = false;
        }
        private void BR_Button_Undo_S_Click(object sender, EventArgs e)
        {
            abandon = true;
            ClearError();
            Link();
            
            
            BR_DS_Chambres.Tables["chambre"].RejectChanges();
            BR_BS_Chambres.ResetCurrentItem();
            ActiveControl_TB(false, false, false, false, false, false, false, false);
            VisibleControle_S(true, true, true, true, true, true);
            ActiveControle_S(false, false, false, false, false, false);
            VisibleControle_G(true, true, true, true, true, true, true);
            DisableButton();
        }
        private void BR_Button_Save_S_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.Position = 0;  //' positionne au 1er enregistrement
            BR_dataRow_Chambre.EndEdit();
            BR_TA_Chambres.Update(BR_DS_Chambres.chambre);

            ActiveControl_TB(false, false, false, false, false, false, false, false);
            VisibleControle_S(true, true, true, true, true, true);
            ActiveControle_S(false, false, false, false, false, false);

            VisibleControle_G(true, true, true, true, true, true, true);
            ActiveControle_G(true, true, true, true, true, true, true, true, true, true, true);
            DisableButton();
            ClearError();
        }
        #endregion

        #region Button_G
        private void BR_Button_Add_G_Click(object sender, EventArgs e)
        {
            abandon = false;

            VisibleControle_G(false, false, false, false, false, false, false);
            ActiveControle_G(false, false, false, false, false, false, false, false, false, false, false);

            VisibleControle_S(false, false, false, true, false, true);
            ActiveControle_S(true, true, true, true, true, true);

            ActiveControl_TB(true, false, false, false, false, false, false, false);

            BR_RTB_Chambres.Enabled = true;

            UnLink();
            ClearField();
            BR_TB_Chambre_NoCham.Focus();
        }
        private void BR_Button_List_G_Click(object sender, EventArgs e)
        {
            //  int oldposition = Bs_Ach.Position;
            //if (Ls_Ach.ShowDialog() != DialogResult.OK)
            // { Bs_Ach.Position = oldposition; }
        }
        private void BR_Button_Gotofirst_G_Click(object sender, EventArgs e)
        {
            ClearError();
            BR_BS_Chambres.MoveFirst();
        }
        private void BR_Button_Previous_G_Click(object sender, EventArgs e)
        {
            ClearError();
            BR_BS_Chambres.MovePrevious();
        }
        private void BR_Button_Next_G_Click(object sender, EventArgs e)
        {
            ClearError();
            BR_BS_Chambres.MoveNext();
        }
        private void BR_Button_Gotoend_G_Click(object sender, EventArgs e)
        {
            ClearError();
            BR_BS_Chambres.MoveLast();
        }
        #endregion

        #region Button_LS
        private void BR_Button_LS_Chambre_S_MouseHover(object sender, EventArgs e)
        {
            Visible_LS_Label(true, false, false, false);
        }
        private void BR_Button_LS_Chambre_S_MouseLeave(object sender, EventArgs e)
        {
            Visible_LS_Label(false, false, false, false);
        }
        private void BR_Button_LS_CodeType_S_MouseHover(object sender, EventArgs e)
        {
            Visible_LS_Label(false, true, false, false);
        }
        private void BR_Button_LS_CodeType_S_MouseLeave(object sender, EventArgs e)
        {
            Visible_LS_Label(false, false, false, false);
        }
        private void BR_Button_LS_CodeLoc_S_MouseHover(object sender, EventArgs e)
        {
            Visible_LS_Label(false, false, true, false);
        }
        private void BR_Button_LS_CodeLoc_S_MouseLeave(object sender, EventArgs e)
        {
            Visible_LS_Label(false, false, false, false);
        }
        private void BR_Button_LS_CodeCom_S_MouseHover(object sender, EventArgs e)
        {
            Visible_LS_Label(false, false, false, true);
        }
        private void BR_Button_LS_CodeCom_S_MouseLeave(object sender, EventArgs e)
        {
            Visible_LS_Label(false, false, false, false);
        }

        private void BR_Button_LS_S_Click(object sender, EventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_NoCham BR_LS_NoCham = new BR_LS_Chambres_NoCham();
            BR_LS_NoCham.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            if (BR_LS_NoCham.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
        }
        private void BR_Button_LS_CodeType_S_Click(object sender, EventArgs e)
        {
            int temp = BR_BS_Chambres_TypeCham.Position;
            BR_LS_Chambres_CodeType BR_LS_CodeType = new BR_LS_Chambres_CodeType();
            BR_LS_CodeType.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres_TypeCham;
            if (BR_LS_CodeType.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres_TypeCham.Position = temp;
            }
            else
            {
                BR_dataRow_Chambre["CodTypCham"] = BR_DS_Chambres.Tables["typecham"].Rows[BR_BS_Chambres_TypeCham.Position]["CodTypCham"];
                BR_dataRow_Chambre["DescTyp"] = BR_DS_Chambres.Tables["typecham"].Rows[BR_BS_Chambres_TypeCham.Position]["DescTyp"];
                BR_TB_Chambre_CodeType.Text = BR_DS_Chambres.Tables["typecham"].Rows[BR_BS_Chambres_TypeCham.Position]["CodTypCham"].ToString();
                BR_TB_Chambre_Desc1.Text = BR_DS_Chambres.Tables["typecham"].Rows[BR_BS_Chambres_TypeCham.Position]["DescTyp"].ToString();
            }
        }
        private void BR_Button_LS_CodeLoc_S_Click(object sender, EventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_CodeLoc BR_LS_CodeLoc = new BR_LS_Chambres_CodeLoc();
            BR_LS_CodeLoc.DBR_LS_DGW_Chambre_CodeLoc.DataSource = BR_BS_Chambres_Localisation;
            if (BR_LS_CodeLoc.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
            else
            {
                BR_dataRow_Chambre["CodLoc"] = BR_DS_Chambres.Tables["localisation"].Rows[BR_BS_Chambres_Localisation.Position]["CodLoc"];
                BR_dataRow_Chambre["DescLoc"] = BR_DS_Chambres.Tables["localisation"].Rows[BR_BS_Chambres_Localisation.Position]["DescLoc"];
                BR_TB_Chambre_CodeLoc.Text = BR_DS_Chambres.Tables["localisation"].Rows[BR_BS_Chambres_Localisation.Position]["CodLoc"].ToString();
                BR_TB_Chambre_Desc2.Text = BR_DS_Chambres.Tables["localisation"].Rows[BR_BS_Chambres_Localisation.Position]["DescLoc"].ToString();
            }
        }
        private void BR_Button_LS_CodeCom_S_Click(object sender, EventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_CodeCom BR_LS_CodeCom = new BR_LS_Chambres_CodeCom();
            BR_LS_CodeCom.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres_CodCom;
            if (BR_LS_CodeCom.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
            else
            {
            }
        }


        #endregion

        #region PixsChange
        private void EnabledButton()
        {
            BR_Button_Add_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_add_S;
            BR_Button_Del_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_list_remove_S;
            BR_Button_View_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_layer_visible_on_S;
            BR_Button_Undo_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_Cancel_S;
            BR_Button_Edit_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_Notes_S;
            BR_Button_Save_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_document_save_S;
            BR_Button_Gotoend_G.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_go_last_block_G;
            BR_Button_Gotofirst_G.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_go_first_block_G;
            BR_Button_Next_G.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_go_next_block_G;
            BR_Button_Previous_G.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_go_previous_block_G;
        }
        private void DisableButton()
        {
            BR_Button_Add_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_add_block_S;
            BR_Button_Del_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_list_remove_block_S;
            BR_Button_View_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_layer_visible_off_S;
            BR_Button_Undo_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_Cancel_Block_S;
            BR_Button_Edit_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_notes_128x128_Block;
            BR_Button_Save_S.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_document_save_Block_S;
            BR_Button_Gotoend_G.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_go_last_G;
            BR_Button_Gotofirst_G.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_go_first_G;
            BR_Button_Next_G.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_go_next_G;
            BR_Button_Previous_G.BackgroundImage = global::Bates_Reservation_Chambres.Properties.Resources.BR_go_previous_G;
        }
        #endregion

        /*public bool ValidEmailAddress(string CodeTypeCham, out string errorMessage)
           {
               // Confirm that the e-mail address string is not empty.
               if (CodeTypeCham.Length == 0)
               {
                   errorMessage = "e-mail address is required.";
                   return false;
               }

               // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
               if (CodeTypeCham.IndexOf("@") > -1)
               {
                   if (CodeTypeCham.IndexOf(".", CodeTypeCham.IndexOf("@")) > CodeTypeCham.IndexOf("@"))
                   {
                       errorMessage = "";
                       BR_TB_Chambre_CodeType.BackColor = Color.GreenYellow;
                       BR_TB_Chambre_CodeType.Enabled = false;
                       BR_TB_Chambre_Desc1.Enabled = true;
                       BR_TB_Chambre_Desc1.Focus();
                       return true;
                   }
               }

               errorMessage = "e-mail address must be valid e-mail address format.\n" +
                  "For example 'someone@example.com' ";
               return false;
           }*/
    }
}
