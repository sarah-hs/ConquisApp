![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.001.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.002.png)

Conquis App ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

Documentación del juego 

Universidad de Montemorelos Facultad de Ingeniería y Tecnología 

Por: 

Alvin García Michael Arthur Samuel Pérez Sarah Hernández 

En cumplimiento a la materia de: Desarrollo de Software para entretenimiento 

Profesor. 

Ing. Ignacio Cruz Domínguez 

02 de diciembre de 2020. Montemorelos, Nuevo León 

ÍNDICE DE CONTENIDO ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

[**Documentación del Juego](#_page3_x72.00_y72.00) **[4](#_page3_x72.00_y72.00)** 

1. [Introducción](#_page3_x72.00_y132.75) [4](#_page3_x72.00_y132.75) 
   1. [Descripción](#_page3_x72.00_y639.00) [4](#_page3_x72.00_y639.00) 
   1. [Requisitos mínimos del sistema](#_page4_x72.00_y279.00) [4](#_page4_x72.00_y279.00) 
1. [Pantalla principal](#_page4_x72.00_y468.00) [5](#_page4_x72.00_y468.00) 
1. [Tutoriales usados](#_page4_x72.00_y519.75) [5](#_page4_x72.00_y519.75) 
1. [Sprites y prefabs](#_page5_x72.00_y134.25) [5](#_page5_x72.00_y134.25) 
   1. [Fuentes de letra](#_page5_x72.00_y178.50) [5](#_page5_x72.00_y178.50) 
   1. [Assets](#_page5_x72.00_y275.25) [5](#_page5_x72.00_y275.25) 
   1. [Prefabs](#_page6_x72.00_y196.50) [6](#_page6_x72.00_y196.50) 
1. [Scripts](#_page7_x72.00_y278.25) [7](#_page7_x72.00_y278.25) 
1. [Script: SceneSwitcher.cs](#_page7_x72.00_y321.75) [7](#_page7_x72.00_y321.75) 
1. [Script: PanelManager.cs](#_page7_x72.00_y501.75) [8](#_page7_x72.00_y501.75) 

   2. [Script: SoundManager.cs](#_page7_x72.00_y602.25) [8](#_page7_x72.00_y602.25) 
   4. [Capturas de pantalla](#_page8_x72.00_y113.25) [8](#_page8_x72.00_y113.25) 
3. [Test de especialidad de nudos](#_page8_x72.00_y411.00) [9](#_page8_x72.00_y411.00) 
   1. [Tutoriales usados](#_page8_x72.00_y462.75) [9](#_page8_x72.00_y462.75) 
   1. [Sprites](#_page9_x72.00_y72.00) [9](#_page9_x72.00_y72.00) 
   1. [Scripts](#_page9_x72.00_y245.25) [9](#_page9_x72.00_y245.25) 
   1. [Capturas de pantalla](#_page11_x72.00_y462.75) [10](#_page11_x72.00_y462.75) 
3. [Memorama](#_page12_x72.00_y474.00) [11](#_page12_x72.00_y474.00) 
1. [Tutoriales usados](#_page12_x72.00_y525.75) [11](#_page12_x72.00_y525.75) 
1. [Sprites](#_page13_x72.00_y72.00) [11](#_page13_x72.00_y72.00) 
1. [Scripts](#_page13_x72.00_y162.00) [11](#_page13_x72.00_y162.00) 
1. [Script: Carta.cs](#_page13_x72.00_y206.25) [11](#_page13_x72.00_y206.25) 
1. [Script: CrearCarta.cs](#_page14_x72.00_y329.25) [13](#_page14_x72.00_y329.25) 
1. [Script: InterfazUsuario.cs](#_page17_x72.00_y501.75) [16](#_page17_x72.00_y501.75) 
5. [Ajedrez](#_page19_x72.00_y72.00) [17](#_page19_x72.00_y72.00) 
   1. [Componentes de la escena del juego](#_page19_x72.00_y229.50) [18](#_page19_x72.00_y229.50) 
   1. [Sprites y prefabs](#_page19_x72.00_y438.00) [18](#_page19_x72.00_y438.00) 
   1. [Scripts](#_page20_x72.00_y213.00) [19](#_page20_x72.00_y213.00) 
5. [TicTacToe](#_page21_x72.00_y72.00) [19](#_page21_x72.00_y72.00) 
1. [Tutoriales usados](#_page21_x72.00_y105.75) [19](#_page21_x72.00_y105.75) 
2. [Sprites](#_page21_x72.00_y164.25) [20](#_page21_x72.00_y164.25) ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)
2. [Scripts](#_page21_x72.00_y208.50) [20](#_page21_x72.00_y208.50) 
1. [Script: GameController.cs](#_page21_x72.00_y269.25) [20](#_page21_x72.00_y269.25) 
1. [Script: GridSpace.cs](#_page26_x72.00_y72.00) [27](#_page26_x72.00_y72.00) 

[**Manual de usuario](#_page26_x72.00_y468.00) **[27](#_page26_x72.00_y468.00)** 

1. [Introducción](#_page27_x72.00_y126.75) [27](#_page27_x72.00_y126.75) 
   1. [Descripción](#_page27_x72.00_y275.25) [28](#_page27_x72.00_y275.25) 
   1. [Requisitos mínimos del sistema](#_page27_x72.00_y567.75) [28](#_page27_x72.00_y567.75) 
1. [Pantalla principal](#_page28_x72.00_y113.25) [28](#_page28_x72.00_y113.25) 
1. [Test de especialidad de nudos](#_page29_x72.00_y333.00) [30](#_page29_x72.00_y333.00) 
   1. [Número de jugadores del juego](#_page29_x72.00_y384.00) [30](#_page29_x72.00_y384.00) 
   1. [Cómo se juega](#_page29_x72.00_y443.25) [30](#_page29_x72.00_y443.25) 
   1. [Capturas de pantalla](#_page30_x72.00_y72.00) [30](#_page30_x72.00_y72.00) 
1. [Memorama](#_page31_x72.00_y387.75) [32](#_page31_x72.00_y387.75) 
   1. [Número de jugadores del juego](#_page31_x72.00_y459.75) [32](#_page31_x72.00_y459.75) 
   1. [Cómo se juega](#_page31_x72.00_y525.00) [32](#_page31_x72.00_y525.00) 
   1. [Capturas de pantalla](#_page32_x72.00_y72.00) [33](#_page32_x72.00_y72.00) 
1. [Ajedrez](#_page33_x72.00_y284.25) [34](#_page33_x72.00_y284.25) 
   1. [Número de jugadores del juego](#_page33_x72.00_y441.00) [34](#_page33_x72.00_y441.00) 
   1. [Cómo se juega](#_page33_x72.00_y521.25) [34](#_page33_x72.00_y521.25) 
   1. [Capturas de pantalla](#_page34_x72.00_y72.00) [35](#_page34_x72.00_y72.00) 
1. [TicTacToe](#_page34_x72.00_y601.50) [35](#_page34_x72.00_y601.50) 
1. [Número de jugadores del juego](#_page34_x72.00_y645.00) [35](#_page34_x72.00_y645.00) 
1. [Cómo se juega](#_page35_x72.00_y72.00) [36](#_page35_x72.00_y72.00) 
1. [Capturas de pantalla](#_page35_x72.00_y204.00) [36](#_page35_x72.00_y204.00) 

Documentación del Juego ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

1. **Introducción** 

En el siguiente enlace de github se puede ver el proyecto completo y es descargable dando click en “Download as zip” de la siguiente manera: 

Enlace: <https://github.com/sarah-hs/ConquisApp>  

Este juego consiste en una serie de juegos que ayudan a los conquistadores a completar, entender ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.004.png)y practicar especialidades. Son aproximadamente 5 especialidades, y se pueden agregar muchísimas más. Se van acumulando puntos en cada juego y el objetivo final es completar las especialidades con el mayor puntaje posible. 

1. Descripción 

Composiciòn de la escena: Primeramente se compone de un menú general para seleccionar la especialidad a practicar, la configuración del juego y el puntaje. En futuros trabajos estos puntajes se pueden actualizar vía internet para poder competir contra otros jugadores. ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

Género: cualquier público,  principalmente jóvenes conquistadores o maestros que trabajan en el área de conquistadores. 

Consiste en los siguientes juegos: 

- Especialidad de nudos 
- Memorama de personajes bíblicos 
- Tic-tac-toe 
- Damas inglesas 
- Ajedrez 
2. Requisitos mínimos del sistema 

Plataforma: PC 

SO: Windows 7/8/10 

Procesador: Intel Pentium Dual Core / AMD FX Memoria: 2 GB RAM 

Tarjeta de Video: Intel HD Graphics Almacenamiento: 100 MB de espacio libre Tarjeta de Sonido: DirectX 

2. **Pantalla principal** 
1. Tutoriales usados 

Utilizamos los siguientes tutoriales para crear el código de funcionamiento de la pantalla principal: <https://www.youtube.com/watch?v=-SL8Zhtxb9c>  <https://www.youtube.com/watch?v=EdhurHPM7Gk> 

Añadir o quitar sonido al dar click: <https://www.youtube.com/watch?v=FxedJgTsFyQ> Sonido: [https://answers.unity.com/questions/1339832/c-on-click-sound-to-play-before-loading-sc ene.html](https://answers.unity.com/questions/1339832/c-on-click-sound-to-play-before-loading-scene.html) [https://answers.unity.com/questions/1531220/how-to-play-a-sound-when-a-prefab-butto n-that-chan.html](https://answers.unity.com/questions/1531220/how-to-play-a-sound-when-a-prefab-button-that-chan.html)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)  

2. Sprites y prefabs 
1. Fuentes de letra 

Las fuentes de letra descargadas de FontSpace que utilizamos: 

Lyons: <https://www.fontspace.com/lyons-2-font-f25160> 

y Retronome regular: <https://www.fontspace.com/retronome-font-f40089> 

2. Assets 

Imagen de background con colores azul, rojo y morado. [https://drive.google.com/file/d/1x0EMHM4ssW4XK3yWKzuNszoRYTPsfUni/view?usp=s haring](https://drive.google.com/file/d/1x0EMHM4ssW4XK3yWKzuNszoRYTPsfUni/view?usp=sharing) 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.005.png)

Estos son los sprites utilizados para los íconos de la App. Fueron descargados de la página de iconscout: <https://iconscout.com/icon-pack/cartoon-game-ui-essential-icons>. 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.006.png)

3. Prefabs ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

**Canvas\_Game** 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.007.png)

**Buttons\_options** 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.008.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.009.png)

**Button\_back** 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.010.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.011.png)

3. Scripts ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)
1. Script: SceneSwitcher.cs 

Este método se llama en el onClick() de los botones correspondientes a cambios de escena, Back Scene, Home y Exit Game.  

Contiene los métodos loadScene(), backScene() y exitGame(): 

loadScene() - guarda la escena actual como prev\_scene y carga una escena específica del juego dado el nombre de esa nueva escena. 

backScene() - carga la escena guardada como prev\_scene. 

exitGame() - Cierra la aplicación. 

2. Script: PanelManager.cs 

Este método se implementa en el botón que abre un panel como el de settings o el de info del juego. Contiene los siguientes métodos: 

openandclose() - determina si el panel está abierto y lo cierra o viceversa. 2.3.2 Script: SoundManager.cs 

Se encarga de hacer mute a la música y a los sonidos del juego. Además que aplica sonido al botón de click. Contiene los siguientes métodos: 

stopMusic() - determina si la música se está reproduciendo y le pone stop o play. muteSounds() - mutea los sonidos del juego o los enciende. 

playClick() - Reproduce un sonido de click al presionar un botón. ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

4. Capturas de pantalla 

El ícono de información muestra la descripción general del juego. 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.012.png)

3. **Test de especialidad de nudos** 

3.1 Tutoriales usados 

<https://www.youtube.com/watch?v=eKzKntYG7Pc> <https://www.youtube.com/watch?v=PDYB32qAsLU> 

**Fuentes de información sobre nudos:** 

Manual de nudos del club de conquistadores: [https://drive.google.com/file/d/1b6792WbYcGiq_dCyABTPt-rSpf2jNSBC/view?usp=shari ng](https://drive.google.com/file/d/1b6792WbYcGiq_dCyABTPt-rSpf2jNSBC/view?usp=sharing) 

Imágenes de especialidades de pinterest: [https://drive.google.com/drive/folders/1aBXCXPP3lP2voTvUM7kcWG9SIfWlws6y?usp= sharing](https://drive.google.com/drive/folders/1aBXCXPP3lP2voTvUM7kcWG9SIfWlws6y?usp=sharing) 
2. Sprites ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

Background de la pantalla principal de especialidades de nudos: [https://drive.google.com/file/d/106fuVHZkDX15kpvTvdDnBtBqgO5mj2jm/view?usp=shar ing](https://drive.google.com/file/d/106fuVHZkDX15kpvTvdDnBtBqgO5mj2jm/view?usp=sharing) 

Background de la pantalla de test y la de menú de nudos: [https://drive.google.com/file/d/1EE_raU-GNYItEz7hCUOgS_gdO7n_rtU1/view?usp=sha ring](https://drive.google.com/file/d/1EE_raU-GNYItEz7hCUOgS_gdO7n_rtU1/view?usp=sharing) 

3. Scripts 

Contiene un solo script que se llama TestManager.cs. Este script se encarga de cargar las preguntas del juego en un scrollView. Las preguntas ya están diseñadas en objetos vacíos, sin embargo este script se encarga de activarlas o desactivarlas según corresponda al ir contestando el test de especialidad de nudos. 

Este script contiene los métodos: 

**NextQuestion()** - que carga la siguiente pregunta cuando es llamado con la acción del botón next y determina si ya hemos llegado a la pregunta final para entonces preguntar al usuario si desea terminar o aún no. 

**PrevQuestion()** - carga la pregunta con el id anterior al actual y si el id es de una pregunta menor a cero (lo cual significa que no existe) entonces no carga ninguna nueva pregunta. 

**CancelFinished() -** si el usuario decide no terminar aún el juego al llegar a la pregunta final, este método se llama y simplemente cierra el panel de preguntar al usuario si desea terminar. 

**YesFinished() -** si el usuario desea terminar el juego entonces este método carga la escena del menú inicial. 

using System.Collections; 

using System.Collections.Generic; using UnityEngine; 

using UnityEngine.UI; 

public class TestManager : MonoBehaviour 

{ ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

`    `public Text tittle; 

`    `public Text instruction; 

`    `public ScrollRect scrollView; 

`    `private string[] tils = { "1. DEFINE LOS SIGUIENTES TÉRMINOS", 

`                            `"2. CÓMO CUIDAR LA CUERDA", 

`                            `"3. CUERDA DE TRES FIBRAS Y CUERDA LISA (CON ALMA)",                             "4. IDENTIFICA LAS SIGUIENTES CLASES DE CUERDA", 

`                            `"5. LA CUERDA SINTÉTICA", 

`                            `"6. IDENTIFICA LO SSIGUIENTES NUDOS"}; 

`    `private string[] ins = { "Relaciona cada definición con su concepto correspondiente:", 

`                            `"Selecciona todas aquellas acciones que hacen referencia a un buen cuidado de las cuerdas.", 

`                            `"¿Cuáles son las diferencias entre una cuerda lisa y la de 3 fibras?", 

`                            `"Escoge entre Manila, Sisal, Nylon y Polipropileno", 

`                            `"¿Cuáles son algunas de las ventajas de la cuerda sintética?", 

`                            `"Elige el nombre del nudo en cada imagen."}; 

`    `public GameObject q1;     public GameObject q2;     public GameObject q3;     public GameObject q4; 

`    `public GameObject q5; 

`    `public GameObject q6; 

`    `public Button prev; 

`    `public Button next; 

`    `public GameObject panel\_terminar; 

`    `private GameObject current\_question;     private GameObject[] questions; 

`    `private int i = -1; 

`    `private float score = 0; 

`    `// Start is called before the first frame update 

`    `void Start() 

`    `{ 

`        `current\_question = GameObject.FindGameObjectWithTag("Panel");         questions = new GameObject[tils.Length]; 

`        `questions[0] = q1; 

`        `questions[1] = q2; 

`        `questions[2] = q3; 

`        `questions[3] = q4; 

`        `questions[4] = q5; 

`        `questions[5] = q6;     } 

`    `public void NextQuestion() 

`    `{ 

`        `if (i==-1) { 

`            `scrollView.gameObject.SetActive(true);             prev.gameObject.SetActive(true); 

`            `next.gameObject.SetActive(true); 

`        `} 

`        `if (i+1 < tils.Length) { 

`            `current\_question.gameObject.SetActive(false); ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)            i += 1; 

`            `tittle.text = tils[i]; 

`            `instruction.text = ins[i]; 

`            `current\_question = questions[i]; 

`            `Debug.Log(current\_question); 

`            `current\_question.gameObject.SetActive(true); 

`        `} else { 

`            `TestFinished();         } 

`    `} 

`    `public void PrevQuestion() 

`    `{ 

`        `if (i-1 >= 0) { 

`            `current\_question.gameObject.SetActive(false);             i -= 1; 

`            `tittle.text = tils[i]; 

`            `instruction.text = ins[i]; 

`            `current\_question = questions[i]; 

`            `current\_question.gameObject.SetActive(true);         } 

`    `} 

`    `void TestFinished() 

`    `{ 

`        `panel\_terminar.gameObject.SetActive(true);     } 

`    `public void CancelFinished() 

`    `{ 

`        `panel\_terminar.gameObject.SetActive(false);     } 

} 

4. Capturas de pantalla 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.013.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.014.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.015.png)

4. **Memorama ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)**

4.1 Tutoriales usados 

A continuación se presentan los tutoriales usados para construir el juego del memorama: 

[Unity 5 - Juego de buscar parejas P.1 - Unity Tutorial español c#](https://www.youtube.com/watch?v=sXIub4yy6Nw)  

[Unity 5 - Juego de buscar parejas P.2 - Unity Tutorial español c#](https://www.youtube.com/watch?v=9po6ap9m_mk)  

[Unity 5 - Juego de buscar parejas P.3 - Unity Tutorial español c#](https://www.youtube.com/watch?v=OJpliwUQwW4)  

[Unity 5 - Juego de buscar parejas P.4 - Unity Tutorial español c#](https://www.youtube.com/watch?v=DG1IUj5v25s) 
2. Sprites ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

[Tarjetas del memorama](https://www.pinterest.com.mx/katthy1974/memorama/) 

[Tarjeta destapada del memorama](https://previews.123rf.com/images/photoestelar/photoestelar1309/photoestelar130900004/21984031-ni%C3%B1os-sentados-leyendo-la-biblia-ilustraci%C3%B3n-conceptual-para-fomentar-la-difusi%C3%B3n-de-la-palabra-de-dios-y-la-.jpg) [Fondo del juego](https://www.xtrafondos.com/wallpapers/resized/rayas-de-colores-2740.jpg?s=large) 

4.3 Scripts 

1. Script: Carta.cs 

Tiene varios métodos pero sirve principalmente para asignar las cartas, para mostrar las cartas ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.016.png)y para hacer los clicks cuando le pica a una carta. 

2. Script: CrearCarta.cs ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.016.png)

Este script es el que hace casi todo el trabajo, sirve para poner contador de las parejas encontradas, el contador de los clicks, el que hace que baraje las cartas y siempre sean aleatorios, el que hace que compare dos cartas se comparen a ver si son iguales, el que reinicia las cartas y muestra el contador de los intentos. 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.017.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.018.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.019.png)

3. Script: InterfazUsuario.cs ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

Este script hace los cambios del interfaz de usuario del juego. Hace las acciones 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.020.png)

5. **Ajedrez ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)**

El juego que se estuvo trabajando durante el semestre fue un ajedrez. El juego fue hecho en Unity, con diversas herramientas, como los sprites, scripts, o las herramientas que ofrece unity. 

El juego tiene como objetivo que los jugadores puedan desarrollar su capacidad de pensar, así como la de tomar decisiones y riesgos para lograr sus metas. Un juego en donde en un movimiento ya sea, lo puedes tener todo, o lo puedes perder. 

1. Componentes de la escena del juego 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.021.png)

2. Sprites y prefabs 

Para el juego se han utilizado dos archivos como base: 

- El tablero del juego fue diseñado en Paint, y fue importado. 
- La piezas del juego fueron descargadas de internet, posteriormente fueron recortadas cada una, de tal manera que puedan usarse las piezas individualmente 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.022.png)

**Prefabs: ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)**

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.023.png)

3. Scripts 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.024.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.025.png)

6. **TicTacToe ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)**
1. Tutoriales usados 

<https://youtu.be/FBamzpJTlG4?list=PLkzh1bySTmYB83ybePBUtsP4t0DAdspiw>  

2. Sprites 
2. Scripts 

Se usaron dos scripts: Game Controller y GridSpace. 

1. Script: GameController.cs 

En el Game Controller están todas las clase que hacen con que el juego funcione, y es la responsable por todos los movimientos que se hacen dentro del juego, como por ejemplo la clase Player para los jugadores desde las imágenes y los botones. 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.026.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.027.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.028.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.029.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.030.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.031.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.032.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.033.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.034.png)

2. Script: GridSpace.cs ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.035.png)

Manual de usuario ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

1. **Introducción** 

Este juego consiste en una serie de juegos que ayudan a los conquistadores a completar, entender y practicar especialidades. Son aproximadamente 5 especialidades, y se pueden agregar muchísimas más. Se van acumulando puntos en cada juego y el objetivo final es completar las especialidades con el mayor puntaje posible. 

1. Descripción 

Composiciòn de la escena: Primeramente se compone de un menú general para seleccionar la especialidad a practicar, la configuración del juego y el puntaje. En futuros trabajos estos puntajes se pueden actualizar vía internet para poder competir contra otros jugadores. 

Género: cualquier público,  principalmente jóvenes conquistadores o maestros que trabajan en el área de conquistadores. 

Consiste en los siguientes juegos: 

- Especialidad de nudos 
- Memorama de personajes bíblicos 
- Tic-tac-toe 
- Damas inglesas 
- Ajedrez 
2. Requisitos mínimos del sistema 

Plataforma: PC 

SO: Windows 7/8/10 

Procesador: Intel Pentium Dual Core / AMD FX Memoria: 2 GB RAM 

Tarjeta de Video: Intel HD Graphics Almacenamiento: 100 MB de espacio libre Tarjeta de Sonido: DirectX ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

2. **Pantalla principal** 

Como en todas las escenas, la pantalla principal contiene un menú de opciones donde el usuario puede seleccionar si mutear o encender el sonido de click durante el jueg, si mutear o encender la música, si regresar a la pantalla principal o si desea salir del juego: 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.036.png)

Además como todas las escenas contiene una descripción general del todo el juego: 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.037.png)

3. **Test de especialidad de nudos ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)**
1. Número de jugadores del juego 

Un jugador. 

2. Cómo se juega 
1. Primeramente el usuario selecciona el botón de comenzar juego y posteriormente se carga la pantalla de la primera pregunta. 
1. El usuario debe ir seleccionando las respuestas correctas a cada pregunta para completar la especialidad. Puede dar scroll para ver las preguntas completas. 
1. Al llegar a la pregunta final es necesario el programa preguntará si desea terminar. Si ya está seguro de haber terminado puede seleccionar el botón de sí, de lo contrario selecciona el botón de no y puede corregir las preguntas en caso de tener duda con sus respuestas dadas. 
1. Al terminar el juego puede completar y evaluar su especialidad. 
3. Capturas de pantalla ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

Comenzar test: 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.038.png)

Contestar según se indica: 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.039.png)

Panel de finalizar juego: ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.040.png)

**4. Memorama** 

En este juego el objetivo es que el jugador encuentre todos los pares de cartas. 

1. Número de jugadores del juego 

Un jugador. 

2. Cómo se juega 

A continuación los pasos para jugar el memorama de personajes bíblicos. 

1. Seleccionar la dificultad con la barra cursora. 
1. Darle a empezar 
1. Seleccionar cartas y encontrar parejas, cada dos cartas que se seleccione se vuelve a tapar y el chiste es encontrar todas las cartas. 
1. Empezar si gustas y seleccionar la dificultad. 
1. Ganas cuando has encontrado la pareja de todas las cartas 
3. Capturas de pantalla ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

Pantalla de seleccionar dificultad: 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.041.png)

Pantalla de juego: 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.042.png)

Pantalla de juego terminado donde puedes saber si perdiste o ganaste: 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.043.png)

5. **Ajedrez ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)**

El juego está compartido con otros más, por lo cual hay una opción para salir del juego y poder ir a otro, o simplemente cerrar la aplicación. 

El juego tiene como objetivo que los jugadores puedan desarrollar su capacidad de pensar, así como la de tomar decisiones y riesgos para lograr sus metas. Un juego en donde en un movimiento ya sea, lo puedes tener todo, o lo puedes perder. 

1. Número de jugadores del juego 

Este juego esta diseñado para jugador vs jugador, en donde se buscará derrotar al rey contrario para obtener la victoria. 

2. Cómo se juega 

En este juego de estrategia se desafía a otro jugador. Al seleccionar una pieza te mostrará las posibles posiciones en donde se podrá mover la pieza, en caso de que pueda comer otra pieza esta se mostraba de otro color. Este es un juego en el que se terminará cuando se coma al rey en jaque mate. 

Cada jugador moverá una pieza por turno. Durante el juego, te muestra las posibles localizaciones en donde se pueda mover en color verde, y en caso de que puedas comer una pieza, se mostrara de color rojo. 
3. Capturas de pantalla ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

**Tablero de inicio** 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.044.png)

**Juego en proceso** 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.045.png)

6. **TicTacToe** 
1. Número de jugadores del juego 

Dos jugadores. 

2. Cómo se juega ![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.003.png)

**¿Cómo se juega? (pasos para jugarlo):** 

Se juega de forma sencilla, con dos personas o de forma automática (o con la compu)  **¿Cómo ganar?** 

Para ganar los competidores tienen que alinear “3X” o “3O” de forma horizontal, vertical o diagonal en la izquierda o derecha. 

3. Capturas de pantalla 

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.046.png)

![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.047.png)![](Documentación%20de%20juego%20en%20Unity%20-%20Conquis%20App.048.png)
