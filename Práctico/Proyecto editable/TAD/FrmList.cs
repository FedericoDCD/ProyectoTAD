using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAD
{
    public partial class FrmList : Form
    {
        List<String> StringList;//Lista con la que trabajar 
        bool List = false;//Booleando que confirma si la lista ha sido creada
        int ItemsCount = 0;//Cantidad de Items en la lista
        public FrmList()
        {
            InitializeComponent();
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BttnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BttnList_Click(object sender, EventArgs e)
        {
            if (!List)
            {//Si no se ha creado la lista la creo
                StringList = new List<string>();
                LblMode.Text = "ESTADO: LISTA CREADA";
                LblItems.Visible = true;
                List = true;
                if (LblErrorAdd.Visible || LblErrorDelete.Visible)
                {//Si hay un error a la vista lo oculto
                    LblErrorAdd.Visible = false;
                    LblErrorDelete.Visible = false;
                }
            }
            else {//Si se ha creado la lista lo informo
                LblErrorCreateList.Text = "*YA EXISTE UNA LISTA";
                LblErrorCreateList.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//Agrego el item ingresado
            AddItem();
        }
        private void AddItem() {//Agrego un item
            if (List)
            {//Si la lista existe procedo
                if (TxtItem.Text != "")
                {//Si hay algo para ingresar lo ingreso a la lista
                    String Item;
                    Item = TxtItem.Text;
                    StringList.Add(Item);
                    LoadList();
                    CmbItem.AddItem(Item);
                    TxtItem.Text = "";
                    BttnList.Focus();
                    ItemsCount++;
                    LblItems.Text = "CANTIDAD DE ITEMS: " + ItemsCount;
                }
                else
                {//Si no hay nada que ingresar aviso que hay un campo sin completar
                    LblErrorAdd.Text = "*CAMPO VACÍO";
                    LblErrorAdd.Visible = true;
                }
            }
            else
            {//Si no se ha creado la lista lo digo
                LblErrorAdd.Text = "*NO EXISTE UNA LISTA";
                LblErrorAdd.Visible = true;
            }
        }
        private void LoadList() {//Cargo un Label con el estado actual de la lista
            for (int i = 0; i < StringList.Count; i++) {
                if (i != 0)//Si es el primer elemento de la lista no le coloco una flecha antes de mostrarlo
                {
                    LblList.Text += " -> " + StringList[i];
                }
                else {
                    LblList.Text = StringList[i];
                }
            }
        }

        private void TxtItem_Enter(object sender, EventArgs e)
        {
            if (LblErrorAdd.Visible || LblErrorCreateList.Visible)//Si se modifica lo ingresado en el textbox oculto el error
            {
                LblErrorAdd.Visible = false; 
                LblErrorCreateList.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (List) {//Si la lista ha sido creada procedo
                if (CmbItem.selectedIndex != -1 && CmbItem.selectedValue != "")
                {//si se ha seleccionado algo en el combobox lo elimino de la lista 
                    if (LblErrorDelete.Visible) {
                        LblErrorDelete.Visible = false;
                    }
                    StringList.Remove(CmbItem.selectedValue);
                    CmbItem.RemoveItem(CmbItem.selectedValue);
                    CmbItem.selectedIndex = 0;
                    LoadList();//ilustro cual es el estado de la lista actual
                    ItemsCount--;
                    LblItems.Text = "CANTIDAD DE ITEMS: " + ItemsCount;
                    if (ItemsCount == 0) {
                        LblList.Text = "";
                    }
                }
                else {//Si no hay un item seleccionado lo digo
                    LblErrorDelete.Text = "*SELECCIONE UN ITEM";
                    LblErrorDelete.Visible = true;
                }
            }else
            {//Si la lista no ha sido creada lo digo
                LblErrorDelete.Text = "*NO EXISTE UNA LISTA";
                LblErrorDelete.Visible = true;
            }
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            CmbItem.AddItem("");
        }

        private void TxtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {//Si se presiona enter ingreso el item
                AddItem();
            }
        }

        private void TxtItem_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
