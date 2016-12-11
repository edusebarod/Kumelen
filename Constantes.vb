Imports System.Globalization

Public Module Cts
    'SaldoCuenta
    Public Const Deudor As Integer = 0
    Public Const Acreedor As Integer = 1

    'TipoMovimiento
    Public Const Cobros As Integer = 0
    Public Const Pagos As Integer = 1

    'Enable
    Public Const Activo As Integer = 1
    Public Const Inactivo As Integer = 0

    'Baja Administrativa
    Public Const Baja As Integer = 1
    Public Const Alta As Integer = 0

    'Pagado
    Public Const Si As Integer = 1
    Public Const No As Integer = 0

    'Sexo
    Public Const Masculino As Char = "M"
    Public Const Femenino As Char = "F"

    'fechas
    'Public provider As CultureInfo = CultureInfo.InvariantCulture
    Public culture = CultureInfo.CreateSpecificCulture("es-ES")
    Public style = DateTimeStyles.None
    Public format As String = "MM-dd-yyyy"
    'CultureInfo("es-ES", False)

    'conexion
    Public via1 As String = "server=107.6.168.250;database=scuhvoay_sistemaNEW;user id=scuhvoay_sistKum;password=KU2015LEN;allowzerodatetime=True"
    Public via2 As String = "server=107.6.168.250;database=scuhvoay_sistemavia2NEW;user id=scuhvoay_sistKum;password=KU2015LEN;allowzerodatetime=True"
    'Public via1 As String = "server=localhost;database=scuhvoay_Sistema;user id=root;allowzerodatetime=True"
    'Public via2 As String = "server=localhost;database=scuhvoay_Sistemavia2;user id=root;allowzerodatetime=True"
    'Public via1 As String = "server=db4free.net;database=kumelen;user id=escuelakumelen;password=Ku20me13len;allowzerodatetime=True"
    'Public via2 As String = "server=db4free.net;database=kumelenvia2;user id=escuelakumelen2;password=Ku20me13len;allowzerodatetime=True"

    'Colores
    'Public frmFondo As Color = Color.Cornsilk
    Public frmFondo As Color = Color.WhiteSmoke

    Public lblFondo As Color = Color.Beige
    Public lblFondoError As Color = Color.LightPink
    Public lblFuente As Color = Color.Black
    Public lblFuenteError As Color = Color.Crimson

    Public txtFondo As Color = Color.White
    Public txtFuente As Color = Color.Black
    Public txtFondoBusco As Color = Color.Khaki
    Public txtFuenteBusco As Color = Color.Black

    Public cmdFondo As Color = Color.Azure
    Public cmdFuente As Color = Color.Black
    Public cmdFondoDisable As Color = Color.LightGray
    Public cmdFuenteDisable As Color = Color.DarkGray

    'Mensajes
    Public Const msgTitulo As String = "KUMELEN"
    Public Const msgGraboOK As String = "¡Se grabo correctamente!"
    Public Const msgValidar As String = "¡Complete los campos obligatorios!"
    Public Const msgExisteNombre As String = "¡Ese nombre ya está utilizado!"
    Public Const msgExisteDNI As String = "¡Ese número de DNI ya está utilizado!"
    Public Const msgPregunta As String = "¿Está seguro de guardar '{0}'?"
    Public Const msgErrBuscaCod As String = "¡No se econtró {0} con ese código!"
    Public Const msgErrCodigoUsado As String = "¡Ese código ya esta en uso!"
    Public Const msgErrGrabo As String = "¡No se pudo grabar, reintente!"
    Public Const msgErrLegajoUsado As String = "¡Ese legajo ya esta en uso!"
    Public Const msgErrSinResultados As String = "¡No existe información asociada a la operación que se está realizando!"
    Public Const msgCompletarNombreyApellido As String = "¡No completó el nombre y7o apellido del alumno!"
    Public Const msgDevengacionAnulada As String = "¡La devengación ha sido anulada!"
    Public Const msgFacturaAnulada As String = "¡La factura ha sido anulada!"

    'Tareas
    Public Const tarFacturacion As Integer = 1

    'Movimientos
    Public Const movPago As Integer = 0
    Public Const movCobro As Integer = 1
    Public Const movPaseIn As Integer = 2
    Public Const movPaseOut As Integer = 3


End Module