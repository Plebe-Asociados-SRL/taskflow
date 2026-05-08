RELEASE V1.0.0 // 07/05/2026

**🚀 Funcionalidades (Features)**

**Gestión de Tareas**

Implementación de la función para crear nuevas tareas [feature/crear-tarea](https://github.com/Plebe-Asociados-SRL/taskflow/pull/26).

Capacidad para listar todas las tareas existentes [feature/listar-tareas](https://github.com/Plebe-Asociados-SRL/taskflow/commit/f6886934345f9b3c04b37bf27ba2acdfc30481b8).

Opción habilitada para la selección de tareas específicas [feature/select-task](https://github.com/Plebe-Asociados-SRL/taskflow/commit/b2ada00889e1b1695078b634dfbbfa119e921f57).

Actualización y visualización del estado de cada tarea a lo largo de su ciclo de vida [feature/actualizarEstado, feature/estado-tarea, feature/update-task-status](https://github.com/Plebe-Asociados-SRL/taskflow/commit/eab7243cbfc83fa5f3dba3a4c459ec609f945420).

**Estructura y Persistencia**

Creación de un Data Transfer Object (TaskItemDTO) para aislar y estructurar el intercambio de datos [Crear-TaskItemDTO](https://github.com/Plebe-Asociados-SRL/taskflow/commit/54042998d6ee238c87fc270f0af0b030fa8c2fba).

Implementación del gestor de archivos (FileManager) para asegurar la lectura y persistencia de la información [feature/implementacion-filemanager](https://github.com/Plebe-Asociados-SRL/taskflow/commit/40a92d107ebdc795aa7eabe40600e13ef8db08b7).

**Interfaz y Asistentes**

Incorporación y estabilización del asistente de la interfaz gráfica de consola (ConsoleHelper). Este componente fue exitosamente re-integrado tras solucionar un flujo de control de versiones previo (revert-40 y revert-45).

**Calidad y Testing**

Se añadieron pruebas unitarias orientadas directamente a la entidad TaskItem.cs [feature/test-TaskItem.cs](https://github.com/Plebe-Asociados-SRL/taskflow/commit/0bbfbb21bea58e6350be14c6bc44e3aab48402dc)

Se integraron pruebas unitarias para validar la lógica de negocio en TaskItemService [feature/test-TaskItemService](ttps://github.com/Plebe-Asociados-SRL/taskflow/commit/0bbfbb21bea58e6350be14c6bc44e3aab48402dc).

**🐛 Bugs Solucionados (Bug Fixes)**

Se reparó un problema lógico y de ejecución provocado por un número introducido de manera accidental en el código [Bug/DejeUnDigitoDeMas](https://github.com/Plebe-Asociados-SRL/taskflow/commit/aa13cabfa3d4fe6a41e2069d02d8f1be2bcabe7a).

Se corrigieron y restauraron las referencias rotas del proyecto que impedían la ejecución del entorno de pruebas [BugFix/testreferences](https://github.com/Plebe-Asociados-SRL/taskflow/commit/c1ac4570d66015323f34196d4303a7ef36f1a5bd).

Se solucionó un fallo técnico puntual relacionado con la correcta sobrecarga de una función [Fix overload func](https://github.com/Plebe-Asociados-SRL/taskflow/commit/07a787135f66c2cd03a6d6c0c442b5500097b8f2)
