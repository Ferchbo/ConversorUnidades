namespace Conversor_de_unidades
{
    public partial class Form1 : Form
    {

        private ConvertirServicio _convertirServicio;
        public Form1()
        {
            InitializeComponent();
            _convertirServicio = new ConvertirServicio();

            cmbTipo.DataSource = Enum.GetValues(typeof(TipoNumeracion));
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstHacia.DataSource = Enum.GetValues(typeof(MasaNumeracion));
            lstDesde.DataSource = Enum.GetValues(typeof(MasaNumeracion));
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = string.Empty;
            txtConvertida.Text = string.Empty;

            var tipo = (TipoNumeracion)cmbTipo.SelectedItem;
            switch (tipo)
            {
                case TipoNumeracion.Masa:
                    lstHacia.DataSource = Enum.GetValues(typeof(MasaNumeracion));
                    lstDesde.DataSource = Enum.GetValues(typeof(MasaNumeracion));
                    break;

                case TipoNumeracion.Temperatura:
                    lstHacia.DataSource = Enum.GetValues(typeof(TemperaturaNumeracion));
                    lstDesde.DataSource = Enum.GetValues(typeof(TemperaturaNumeracion));
                    break;

                case TipoNumeracion.Tiempo:
                    lstHacia.DataSource = Enum.GetValues(typeof(TiempoNumeracion));
                    lstDesde.DataSource = Enum.GetValues(typeof(TiempoNumeracion));
                    break;
                default:
                    break;

            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length <= 0)
                return;
            if (lstDesde.SelectedItems == lstHacia.SelectedItems)
            {
                txtConvertida.Text = txtCantidad.Text;
            }

            var tipo = (TipoNumeracion)cmbTipo.SelectedItem;
            double cantidad = double.Parse(txtCantidad.Text);
            double cantidadConvertida = 0;

            switch (tipo)
            {
                case TipoNumeracion.Masa:
                    var masaDesde = (MasaNumeracion)lstDesde.SelectedItem;
                    var masaHacia = (MasaNumeracion)lstHacia.SelectedItem;
                    cantidadConvertida = _convertirServicio.convertirMasa(masaDesde, masaHacia, cantidad);
                    break;
                case TipoNumeracion.Temperatura:
                cantidadConvertida = _convertirServicio.convertirTemperatura((TemperaturaNumeracion)lstDesde.SelectedItem, (TemperaturaNumeracion)lstHacia.SelectedItem, cantidad);
                    break;
                case TipoNumeracion.Tiempo:
                    var Desde = (TiempoNumeracion)lstDesde.SelectedItem;
                    var Hacia = (TiempoNumeracion)lstHacia.SelectedItem;
                    cantidadConvertida = _convertirServicio.convertirTiempo(Desde, Hacia, cantidad);
                    break;

            }

            txtConvertida.Text = cantidadConvertida.ToString();

        }
    }
}