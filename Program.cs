// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Versión: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estado: Proyecto inicializado");
Console.WriteLine();
Console.WriteLine("Estructura Del Proyecto:");
Console.WriteLine("   InventarioApp/");
Console.WriteLine("|-- Program.cs");
Console.WriteLine("|-- InventarioApp.csproj");
Console.WriteLine("|-- Gitignore");
Console.WriteLine("|-- Readme.md");
Console.WriteLine("|-- src/");
Console.WriteLine("       |--Models/ (próxima clase)");
Console.WriteLine("Configuración .csproj");
Console.WriteLine("Carpeta src/ Creada");
Console.WriteLine("Metadatos del proyecto establecidos");
Console.WriteLine();
Console.WriteLine("Próximos pasos: agregar argumentos CLI y configuración de repositorio en GitHub.");