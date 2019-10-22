using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace TAD
{
    public partial class FrmABB : Form
    {
        Tree ObjTree = new Tree();
        bool TreeMode = false;//Indica si el árbol ha sido creado
        int Items=0;
        public FrmABB()
        {
            InitializeComponent();
            SetMaximumLength(TxtItem, 8);
        }
        
        private void BttnList_Click(object sender, EventArgs e)
        {
            if (!TreeMode)
            {//Si no existe el árbol lo hago válido
                LblMode.Text = "ESTADO: ÁRBOL CREADO";
                LblItems.Visible = true;
                TreeMode = true;
            }
            else {//Si está válido muestro error de creación
                lblItemError.Text = "*YA EXISTE UN ÁRBOL";
                lblItemError.Visible = true;
            }
        }

        private void ListTree() {//Listo los items del árbol
            ObjTree.ClearList();
            ObjTree.Inorder(ObjTree.ReturnRoot());
            ObjTree.Preorder(ObjTree.ReturnRoot());
            ObjTree.Postorder(ObjTree.ReturnRoot());
            LblEnOrden.Invoke(new Action(() => { LblEnOrden.Text = ObjTree.InOrder; }));//Invoco con los labels para evitar errores con los hilos
            LblPreOrden.Invoke(new Action(() => { LblPreOrden.Text = ObjTree.PreOrder; }));
            LblPosOrden.Invoke(new Action(() => { LblPosOrden.Text = ObjTree.PostOrder; }));
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertItem();//Inserto un Item
        }
        private void InsertItem() {//Inserto el Item ingresado en un TextBox
            int Item;
            Thread ThrdList = new Thread(ListTree);
            if (TreeMode)
            {//Si existe el árbol ingreso el item
                if (TxtItem.Text != "")
                {//Si hay algo que ingresar lo ingreso
                    Item = int.Parse(TxtItem.Text);
                    ObjTree.FindItem(ObjTree.ReturnRoot(), Item);
                    if (ObjTree.Empty)
                    {//Si lo ingresado no se repite con ningún item lo ingreso
                        ObjTree.Insert(Item);//Inserto un item
                        ThrdList.Start();
                        TxtItem.Text = "";//Limpio el campo
                        Items++;
                        LblItems.Text = Items.ToString();
                        if (lblItemError.Visible)
                        {//Si está visible algún error lo oculto
                            lblItemError.Visible = false;
                        }
                    }
                    else {//sino informo del error respecto a la inserción del item y seteo el Empty de objtree para futuros ingresos
                        lblItemError.Text = "*ITEM YA INGRESADO";
                        lblItemError.Visible = true;
                        ObjTree.Empty = true;//Seteo el Empty
                    }
                }
                else
                {//Si no hay nada que ingresar lo digo
                    lblItemError.Text = "*CAMPOS SIN RELLENAR";
                    lblItemError.Visible = true;
                }
            }
            else
            {//Si no existe el árbol lo digo
                lblItemError.Text = "*NO EXISTE UN ÁRBOL";
                lblItemError.Visible = true;
            }
        }
        private void TxtItem_Enter(object sender, EventArgs e)
        {
            if (lblItemError.Visible) {//Si hay un error a la vista lo oculto
                lblItemError.Visible = false;
            }
        }

        private void TxtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//Si se presiona enter ingreso el item
                InsertItem();
            }
        }

        private void TxtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Controlo que sólo se ingresen números
            {
                e.Handled = true;
            }
        }
        private void SetMaximumLength(Bunifu.Framework.UI.BunifuMaterialTextbox MaterialTextbox, int maximumLength)//Setea el largo de los datos ingresados en un material textbox
        {
            foreach (Control ctl in MaterialTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;

                    // Set other properties & events here...
                }
            }
        }

        private void FrmABB_Load(object sender, EventArgs e)
        {

        }
    }
}
