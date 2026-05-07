RELEASE V1.0.0 // 07/05/2026

**🚀 Funcionalidades (Features)**

**Gestión de Tareas**

Implementación de la función para crear nuevas tareas [feature/crear-tarea](https://github.com/Plebe-Asociados-SRL/taskflow/pull/26).

Capacidad para listar todas las tareas existentes [feature/listar-tareas]().

Opción habilitada para la selección de tareas específicas [feature/select-task]().

Actualización y visualización del estado de cada tarea a lo largo de su ciclo de vida [feature/actualizarEstado, feature/estado-tarea, feature/update-task-status]().

**Estructura y Persistencia**

Creación de un Data Transfer Object (TaskItemDTO) para aislar y estructurar el intercambio de datos [Crear-TaskItemDTO]().

Implementación del gestor de archivos (FileManager) para asegurar la lectura y persistencia de la información [feature/implementacion-filemanager]().

**Interfaz y Asistentes**

Incorporación y estabilización del asistente de la interfaz gráfica de consola (ConsoleHelper). Este componente fue exitosamente re-integrado tras solucionar un flujo de control de versiones previo (revert-40 y revert-45).

**Calidad y Testing**

Se añadieron pruebas unitarias orientadas directamente a la entidad TaskItem.cs [feature/test-TaskItem.cs]().

Se integraron pruebas unitarias para validar la lógica de negocio en TaskItemService [feature/test-TaskItemService]().

**🐛 Bugs Solucionados (Bug Fixes)**

Se reparó un problema lógico y de ejecución provocado por un número introducido de manera accidental en el código [Bug/DejeUnDigitoDeMas]().

Se corrigieron y restauraron las referencias rotas del proyecto que impedían la ejecución del entorno de pruebas [BugFix/testreferences]().

Se solucionó un fallo técnico puntual relacionado con la correcta sobrecarga de una función [Fix overload func]()
