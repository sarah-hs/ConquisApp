

Conquis App

Documentación del juego

Universidad de Montemorelos

Facultad de Ingeniería y Tecnología

Por:

Alvin García

Michael Arthur

Samuel Pérez

Sarah Hernández

En cumplimiento a la materia de:

Desarrollo de Software para entretenimiento

Profesor.

Ing. Ignacio Cruz Domínguez

02 de diciembre de 2020. Montemorelos, Nuevo León





ÍNDICE DE CONTENIDO

**Documentación del Juego**

\1. Introducción

**4**

4

1.1 Descripción

4

1.2 Requisitos mínimos del sistema

\2. Pantalla principal

2.1 Tutoriales usados

2.2 Sprites y prefabs

2.2.1 Fuentes de letra

2.2.2 Assets

4

5

5

5

5

5

2.2.3 Prefabs

6

2.3 Scripts

7

2.3.1 Script: SceneSwitcher.cs

2.3.2 Script: PanelManager.cs

2.3.2 Script: SoundManager.cs

2.4 Capturas de pantalla

\3. Test de especialidad de nudos

3.1 Tutoriales usados

3.2 Sprites

7

8

8

8

9

9

9

3.3 Scripts

9

3.4 Capturas de pantalla

\4. Memorama

10

11

11

11

11

11

13

16

17

18

18

19

19

19

4.1 Tutoriales usados

4.2 Sprites

4.3 Scripts

4.3.1 Script: Carta.cs

4.3.2 Script: CrearCarta.cs

4.3.3 Script: InterfazUsuario.cs

\5. Ajedrez

5.1 Componentes de la escena del juego

5.2 Sprites y prefabs

5.3 Scripts

\6. TicTacToe

6.1 Tutoriales usados





6.2 Sprites

6.3 Scripts

20

20

20

27

6.3.1 Script: GameController.cs

6.3.2 Script: GridSpace.cs

**Manual de usuario**

**27**

27

28

28

28

30

30

30

30

32

32

32

33

34

34

34

35

35

35

36

36

\1. Introducción

1.1 Descripción

1.2 Requisitos mínimos del sistema

\2. Pantalla principal

\3. Test de especialidad de nudos

3.1 Número de jugadores del juego

3.2 Cómo se juega

3.3 Capturas de pantalla

\4. Memorama

4.1 Número de jugadores del juego

4.2 Cómo se juega

4.3 Capturas de pantalla

\5. Ajedrez

5.1 Número de jugadores del juego

5.2 Cómo se juega

5.3 Capturas de pantalla

\6. TicTacToe

6.1 Número de jugadores del juego

6.2 Cómo se juega

6.3 Capturas de pantalla





Documentación del Juego

**1. Introducción**

En el siguiente enlace de github se puede ver el proyecto completo y es descargable

dando click en “Download as zip” de la siguiente manera:

Enlace: <https://github.com/sarah-hs/ConquisApp>

Este juego consiste en una serie de juegos que ayudan a los conquistadores a

completar, entender y practicar especialidades. Son aproximadamente 5

especialidades, y se pueden agregar muchísimas más. Se van acumulando puntos en

cada juego y el objetivo final es completar las especialidades con el mayor puntaje

posible.

1.1 Descripción

Composiciòn de la escena: Primeramente se compone de un menú general para

seleccionar la especialidad a practicar, la configuración del juego y el puntaje. En





futuros trabajos estos puntajes se pueden actualizar vía internet para poder competir

contra otros jugadores.

Género: cualquier público, principalmente jóvenes conquistadores o maestros que

trabajan en el área de conquistadores.

Consiste en los siguientes juegos:

● Especialidad de nudos

● Memorama de personajes bíblicos

● Tic-tac-toe

● Damas inglesas

● Ajedrez

1.2 Requisitos mínimos del sistema

Plataforma: PC

SO: Windows 7/8/10

Procesador: Intel Pentium Dual Core / AMD FX

Memoria: 2 GB RAM

Tarjeta de Video: Intel HD Graphics

Almacenamiento: 100 MB de espacio libre

Tarjeta de Sonido: DirectX

**2. Pantalla principal**

2.1 Tutoriales usados

Utilizamos los siguientes tutoriales para crear el código de funcionamiento de la

pantalla principal: <https://www.youtube.com/watch?v=-SL8Zhtxb9c>

<https://www.youtube.com/watch?v=EdhurHPM7Gk>

Añadir o quitar sonido al dar click: <https://www.youtube.com/watch?v=FxedJgTsFyQ>

Sonido:

[https://answers.unity.com/questions/1339832/c-on-click-sound-to-play-before-loading-sc](https://answers.unity.com/questions/1339832/c-on-click-sound-to-play-before-loading-scene.html)

[ene.html](https://answers.unity.com/questions/1339832/c-on-click-sound-to-play-before-loading-scene.html)





[https://answers.unity.com/questions/1531220/how-to-play-a-sound-when-a-prefab-butto](https://answers.unity.com/questions/1531220/how-to-play-a-sound-when-a-prefab-button-that-chan.html)

[n-that-chan.html](https://answers.unity.com/questions/1531220/how-to-play-a-sound-when-a-prefab-button-that-chan.html)

2.2 Sprites y prefabs

2.2.1 Fuentes de letra

Las fuentes de letra descargadas de FontSpace que utilizamos:

Lyons: <https://www.fontspace.com/lyons-2-font-f25160>

y Retronome regular: <https://www.fontspace.com/retronome-font-f40089>

2.2.2 Assets

Imagen de background con colores azul, rojo y morado.

[https://drive.google.com/file/d/1x0EMHM4ssW4XK3yWKzuNszoRYTPsfUni/view?usp=s](https://drive.google.com/file/d/1x0EMHM4ssW4XK3yWKzuNszoRYTPsfUni/view?usp=sharing)

[haring](https://drive.google.com/file/d/1x0EMHM4ssW4XK3yWKzuNszoRYTPsfUni/view?usp=sharing)

Estos son los sprites utilizados para los íconos de la App. Fueron descargados de la

página de iconscout: <https://iconscout.com/icon-pack/cartoon-game-ui-essential-icons>.





2.2.3 Prefabs

**Canvas\_Game**

**Buttons\_options**

**Button\_back**





2.3 Scripts

2.3.1 Script: SceneSwitcher.cs

Este método se llama en el onClick() de los botones correspondientes a cambios de

escena, Back Scene, Home y Exit Game.

Contiene los métodos loadScene(), backScene() y exitGame():

loadScene() - guarda la escena actual como prev\_scene y carga una escena

específica del juego dado el nombre de esa nueva escena.

backScene() - carga la escena guardada como prev\_scene.

exitGame() - Cierra la aplicación.

2.3.2 Script: PanelManager.cs

Este método se implementa en el botón que abre un panel como el de settings o el de

info del juego. Contiene los siguientes métodos:

openandclose() - determina si el panel está abierto y lo cierra o viceversa.

2.3.2 Script: SoundManager.cs

Se encarga de hacer mute a la música y a los sonidos del juego. Además que aplica

sonido al botón de click. Contiene los siguientes métodos:

stopMusic() - determina si la música se está reproduciendo y le pone stop o play.

muteSounds() - mutea los sonidos del juego o los enciende.





playClick() - Reproduce un sonido de click al presionar un botón.

2.4 Capturas de pantalla

El ícono de información muestra la descripción general del juego.

**3. Test de especialidad de nudos**

3.1 Tutoriales usados

<https://www.youtube.com/watch?v=eKzKntYG7Pc>

<https://www.youtube.com/watch?v=PDYB32qAsLU>

**Fuentes de información sobre nudos:**

Manual de nudos del club de conquistadores:

[https://drive.google.com/file/d/1b6792WbYcGiq_dCyABTPt-rSpf2jNSBC/view?usp=shari](https://drive.google.com/file/d/1b6792WbYcGiq_dCyABTPt-rSpf2jNSBC/view?usp=sharing)

[ng](https://drive.google.com/file/d/1b6792WbYcGiq_dCyABTPt-rSpf2jNSBC/view?usp=sharing)

Imágenes de especialidades de pinterest:

[https://drive.google.com/drive/folders/1aBXCXPP3lP2voTvUM7kcWG9SIfWlws6y?usp=](https://drive.google.com/drive/folders/1aBXCXPP3lP2voTvUM7kcWG9SIfWlws6y?usp=sharing)

[sharing](https://drive.google.com/drive/folders/1aBXCXPP3lP2voTvUM7kcWG9SIfWlws6y?usp=sharing)





3.2 Sprites

Background de la pantalla principal de especialidades de nudos:

[https://drive.google.com/file/d/106fuVHZkDX15kpvTvdDnBtBqgO5mj2jm/view?usp=shar](https://drive.google.com/file/d/106fuVHZkDX15kpvTvdDnBtBqgO5mj2jm/view?usp=sharing)

[ing](https://drive.google.com/file/d/106fuVHZkDX15kpvTvdDnBtBqgO5mj2jm/view?usp=sharing)

Background de la pantalla de test y la de menú de nudos:

[https://drive.google.com/file/d/1EE_raU-GNYItEz7hCUOgS_gdO7n_rtU1/view?usp=sha](https://drive.google.com/file/d/1EE_raU-GNYItEz7hCUOgS_gdO7n_rtU1/view?usp=sharing)

[ring](https://drive.google.com/file/d/1EE_raU-GNYItEz7hCUOgS_gdO7n_rtU1/view?usp=sharing)

3.3 Scripts

Contiene un solo script que se llama TestManager.cs. Este script se encarga de cargar

las preguntas del juego en un scrollView. Las preguntas ya están diseñadas en objetos

vacíos, sin embargo este script se encarga de activarlas o desactivarlas según

corresponda al ir contestando el test de especialidad de nudos.

Este script contiene los métodos:

**NextQuestion()** - que carga la siguiente pregunta cuando es llamado con la acción del

botón next y determina si ya hemos llegado a la pregunta final para entonces preguntar

al usuario si desea terminar o aún no.

**PrevQuestion()** - carga la pregunta con el id anterior al actual y si el id es de una

pregunta menor a cero (lo cual significa que no existe) entonces no carga ninguna

nueva pregunta.

**CancelFinished() -** si el usuario decide no terminar aún el juego al llegar a la pregunta

final, este método se llama y simplemente cierra el panel de preguntar al usuario si

desea terminar.

**YesFinished() -** si el usuario desea terminar el juego entonces este método carga la

escena del menú inicial.

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class TestManager : MonoBehaviour





{

public Text tittle;

public Text instruction;

public ScrollRect scrollView;

private string[] tils = { "1. DEFINE LOS SIGUIENTES TÉRMINOS",

"2. CÓMO CUIDAR LA CUERDA",

"3. CUERDA DE TRES FIBRAS Y CUERDA LISA (CON ALMA)",

"4. IDENTIFICA LAS SIGUIENTES CLASES DE CUERDA",

"5. LA CUERDA SINTÉTICA",

"6. IDENTIFICA LO SSIGUIENTES NUDOS"};

private string[] ins = { "Relaciona cada definición con su concepto correspondiente:",

"Selecciona todas aquellas acciones que hacen referencia a un buen cuidado de las

cuerdas.",

"¿Cuáles son las diferencias entre una cuerda lisa y la de 3 fibras?",

"Escoge entre Manila, Sisal, Nylon y Polipropileno",

"¿Cuáles son algunas de las ventajas de la cuerda sintética?",

"Elige el nombre del nudo en cada imagen."};

public GameObject q1;

public GameObject q2;

public GameObject q3;

public GameObject q4;

public GameObject q5;

public GameObject q6;

public Button prev;

public Button next;

public GameObject panel\_terminar;

private GameObject current\_question;

private GameObject[] questions;

private int i = -1;

private float score = 0;

// Start is called before the first frame update

void Start()

{

current\_question = GameObject.FindGameObjectWithTag("Panel");

questions = new GameObject[tils.Length];

questions[0] = q1;

questions[1] = q2;

questions[2] = q3;

questions[3] = q4;

questions[4] = q5;

questions[5] = q6;

}

public void NextQuestion()

{

if (i==-1) {

scrollView.gameObject.SetActive(true);

prev.gameObject.SetActive(true);

next.gameObject.SetActive(true);

}

if (i+1 < tils.Length) {





current\_question.gameObject.SetActive(false);

i += 1;

tittle.text = tils[i];

instruction.text = ins[i];

current\_question = questions[i];

Debug.Log(current\_question);

current\_question.gameObject.SetActive(true);

} else {

TestFinished();

}

}

public void PrevQuestion()

{

if (i-1 >= 0) {

current\_question.gameObject.SetActive(false);

i -= 1;

tittle.text = tils[i];

instruction.text = ins[i];

current\_question = questions[i];

current\_question.gameObject.SetActive(true);

}

}

void TestFinished()

{

panel\_terminar.gameObject.SetActive(true);

}

public void CancelFinished()

{

panel\_terminar.gameObject.SetActive(false);

}

}

3.4 Capturas de pantalla





**4. Memorama**

4.1 Tutoriales usados

A continuación se presentan los tutoriales usados para construir el juego del

memorama:

[Unity](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[5](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[-](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[Juego](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[de](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[buscar](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[parejas](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[P.1](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[-](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[Unity](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[Tutorial](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[español](https://www.youtube.com/watch?v=sXIub4yy6Nw)[ ](https://www.youtube.com/watch?v=sXIub4yy6Nw)[c#](https://www.youtube.com/watch?v=sXIub4yy6Nw)

[Unity](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[5](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[-](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[Juego](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[de](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[buscar](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[parejas](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[P.2](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[-](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[Unity](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[Tutorial](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[español](https://www.youtube.com/watch?v=9po6ap9m_mk)[ ](https://www.youtube.com/watch?v=9po6ap9m_mk)[c#](https://www.youtube.com/watch?v=9po6ap9m_mk)

[Unity](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[5](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[-](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[Juego](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[de](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[buscar](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[parejas](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[P.3](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[-](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[Unity](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[Tutorial](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[español](https://www.youtube.com/watch?v=OJpliwUQwW4)[ ](https://www.youtube.com/watch?v=OJpliwUQwW4)[c#](https://www.youtube.com/watch?v=OJpliwUQwW4)

[Unity](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[5](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[-](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[Juego](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[de](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[buscar](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[parejas](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[P.4](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[-](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[Unity](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[Tutorial](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[español](https://www.youtube.com/watch?v=DG1IUj5v25s)[ ](https://www.youtube.com/watch?v=DG1IUj5v25s)[c#](https://www.youtube.com/watch?v=DG1IUj5v25s)





4.2 Sprites

[Tarjetas](https://www.pinterest.com.mx/katthy1974/memorama/)[ ](https://www.pinterest.com.mx/katthy1974/memorama/)[del](https://www.pinterest.com.mx/katthy1974/memorama/)[ ](https://www.pinterest.com.mx/katthy1974/memorama/)[memorama](https://www.pinterest.com.mx/katthy1974/memorama/)

[Tarjeta](https://previews.123rf.com/images/photoestelar/photoestelar1309/photoestelar130900004/21984031-ni%C3%B1os-sentados-leyendo-la-biblia-ilustraci%C3%B3n-conceptual-para-fomentar-la-difusi%C3%B3n-de-la-palabra-de-dios-y-la-.jpg)[ ](https://previews.123rf.com/images/photoestelar/photoestelar1309/photoestelar130900004/21984031-ni%C3%B1os-sentados-leyendo-la-biblia-ilustraci%C3%B3n-conceptual-para-fomentar-la-difusi%C3%B3n-de-la-palabra-de-dios-y-la-.jpg)[destapada](https://previews.123rf.com/images/photoestelar/photoestelar1309/photoestelar130900004/21984031-ni%C3%B1os-sentados-leyendo-la-biblia-ilustraci%C3%B3n-conceptual-para-fomentar-la-difusi%C3%B3n-de-la-palabra-de-dios-y-la-.jpg)[ ](https://previews.123rf.com/images/photoestelar/photoestelar1309/photoestelar130900004/21984031-ni%C3%B1os-sentados-leyendo-la-biblia-ilustraci%C3%B3n-conceptual-para-fomentar-la-difusi%C3%B3n-de-la-palabra-de-dios-y-la-.jpg)[del](https://previews.123rf.com/images/photoestelar/photoestelar1309/photoestelar130900004/21984031-ni%C3%B1os-sentados-leyendo-la-biblia-ilustraci%C3%B3n-conceptual-para-fomentar-la-difusi%C3%B3n-de-la-palabra-de-dios-y-la-.jpg)[ ](https://previews.123rf.com/images/photoestelar/photoestelar1309/photoestelar130900004/21984031-ni%C3%B1os-sentados-leyendo-la-biblia-ilustraci%C3%B3n-conceptual-para-fomentar-la-difusi%C3%B3n-de-la-palabra-de-dios-y-la-.jpg)[memorama](https://previews.123rf.com/images/photoestelar/photoestelar1309/photoestelar130900004/21984031-ni%C3%B1os-sentados-leyendo-la-biblia-ilustraci%C3%B3n-conceptual-para-fomentar-la-difusi%C3%B3n-de-la-palabra-de-dios-y-la-.jpg)

[Fondo](https://www.xtrafondos.com/wallpapers/resized/rayas-de-colores-2740.jpg?s=large)[ ](https://www.xtrafondos.com/wallpapers/resized/rayas-de-colores-2740.jpg?s=large)[del](https://www.xtrafondos.com/wallpapers/resized/rayas-de-colores-2740.jpg?s=large)[ ](https://www.xtrafondos.com/wallpapers/resized/rayas-de-colores-2740.jpg?s=large)[juego](https://www.xtrafondos.com/wallpapers/resized/rayas-de-colores-2740.jpg?s=large)

4.3 Scripts

4.3.1 Script: Carta.cs

Tiene varios métodos pero sirve principalmente para asignar las cartas, para mostrar

las cartas y para hacer los clicks cuando le pica a una carta.





4.3.2 Script: CrearCarta.cs

Este script es el que hace casi todo el trabajo, sirve para poner contador de las parejas

encontradas, el contador de los clicks, el que hace que baraje las cartas y siempre

sean aleatorios, el que hace que compare dos cartas se comparen a ver si son iguales,

el que reinicia las cartas y muestra el contador de los intentos.













4.3.3 Script: InterfazUsuario.cs

Este script hace los cambios del interfaz de usuario del juego. Hace las acciones









**5. Ajedrez**

El juego que se estuvo trabajando durante el semestre fue un ajedrez. El juego fue

hecho en Unity, con diversas herramientas, como los sprites, scripts, o las herramientas

que ofrece unity.

El juego tiene como objetivo que los jugadores puedan desarrollar su capacidad de

pensar, así como la de tomar decisiones y riesgos para lograr sus metas. Un juego en

donde en un movimiento ya sea, lo puedes tener todo, o lo puedes perder.

5.1 Componentes de la escena del juego

5.2 Sprites y prefabs

Para el juego se han utilizado dos archivos como base:

\- El tablero del juego fue diseñado en Paint, y fue importado.

\- La piezas del juego fueron descargadas de internet, posteriormente fueron recortadas

cada una, de tal manera que puedan usarse las piezas individualmente





**Prefabs:**

5.3 Scripts





**6. TicTacToe**

6.1 Tutoriales usados

<https://youtu.be/FBamzpJTlG4?list=PLkzh1bySTmYB83ybePBUtsP4t0DAdspiw>

6.2 Sprites

6.3 Scripts

Se usaron dos scripts: Game Controller y GridSpace.

6.3.1 Script: GameController.cs

En el Game Controller están todas las clase que hacen con que el juego funcione, y es

la responsable por todos los movimientos que se hacen dentro del juego, como por

ejemplo la clase Player para los jugadores desde las imágenes y los botones.





















6.3.2 Script: GridSpace.cs





Manual de usuario

**1. Introducción**

Este juego consiste en una serie de juegos que ayudan a los conquistadores a

completar, entender y practicar especialidades. Son aproximadamente 5

especialidades, y se pueden agregar muchísimas más. Se van acumulando puntos en

cada juego y el objetivo final es completar las especialidades con el mayor puntaje

posible.

1.1 Descripción

Composiciòn de la escena: Primeramente se compone de un menú general para

seleccionar la especialidad a practicar, la configuración del juego y el puntaje. En

futuros trabajos estos puntajes se pueden actualizar vía internet para poder competir

contra otros jugadores.

Género: cualquier público, principalmente jóvenes conquistadores o maestros que

trabajan en el área de conquistadores.

Consiste en los siguientes juegos:

● Especialidad de nudos

● Memorama de personajes bíblicos

● Tic-tac-toe

● Damas inglesas

● Ajedrez

1.2 Requisitos mínimos del sistema

Plataforma: PC

SO: Windows 7/8/10

Procesador: Intel Pentium Dual Core / AMD FX

Memoria: 2 GB RAM

Tarjeta de Video: Intel HD Graphics





Almacenamiento: 100 MB de espacio libre

Tarjeta de Sonido: DirectX

**2. Pantalla principal**

Como en todas las escenas, la pantalla principal contiene un menú de opciones donde

el usuario puede seleccionar si mutear o encender el sonido de click durante el jueg, si

mutear o encender la música, si regresar a la pantalla principal o si desea salir del

juego:

Además como todas las escenas contiene una descripción general del todo el juego:





**3. Test de especialidad de nudos**

3.1 Número de jugadores del juego

Un jugador.

3.2 Cómo se juega

\1. Primeramente el usuario selecciona el botón de comenzar juego y posteriormente se

carga la pantalla de la primera pregunta.

\2. El usuario debe ir seleccionando las respuestas correctas a cada pregunta para

completar la especialidad. Puede dar scroll para ver las preguntas completas.

\3. Al llegar a la pregunta final es necesario el programa preguntará si desea terminar.

Si ya está seguro de haber terminado puede seleccionar el botón de sí, de lo contrario

selecciona el botón de no y puede corregir las preguntas en caso de tener duda con

sus respuestas dadas.

\4. Al terminar el juego puede completar y evaluar su especialidad.





3.3 Capturas de pantalla

Comenzar test:

Contestar según se indica:





Panel de finalizar juego:

**4. Memorama**

En este juego el objetivo es que el jugador encuentre todos los pares de cartas.

4.1 Número de jugadores del juego

Un jugador.

4.2 Cómo se juega

A continuación los pasos para jugar el memorama de personajes bíblicos.

\1. Seleccionar la dificultad con la barra cursora.

\2. Darle a empezar

\3. Seleccionar cartas y encontrar parejas, cada dos cartas que se seleccione

se vuelve a tapar y el chiste es encontrar todas las cartas.

\4. Empezar si gustas y seleccionar la dificultad.

\5. Ganas cuando has encontrado la pareja de todas las cartas





4.3 Capturas de pantalla

Pantalla de seleccionar dificultad:

Pantalla de juego:

Pantalla de juego terminado donde puedes saber si perdiste o ganaste:





**5. Ajedrez**

El juego está compartido con otros más, por lo cual hay una opción para salir del juego

y poder ir a otro, o simplemente cerrar la aplicación.

El juego tiene como objetivo que los jugadores puedan desarrollar su capacidad de

pensar, así como la de tomar decisiones y riesgos para lograr sus metas. Un juego en

donde en un movimiento ya sea, lo puedes tener todo, o lo puedes perder.

5.1 Número de jugadores del juego

Este juego esta diseñado para jugador vs jugador, en donde se buscará derrotar al rey

contrario para obtener la victoria.

5.2 Cómo se juega

En este juego de estrategia se desafía a otro jugador. Al seleccionar una pieza te

mostrará las posibles posiciones en donde se podrá mover la pieza, en caso de que

pueda comer otra pieza esta se mostraba de otro color. Este es un juego en el que se

terminará cuando se coma al rey en jaque mate.

Cada jugador moverá una pieza por turno. Durante el juego, te muestra las posibles

localizaciones en donde se pueda mover en color verde, y en caso de que puedas

comer una pieza, se mostrara de color rojo.





5.3 Capturas de pantalla

**Tablero de inicio**

**Juego en proceso**

**6. TicTacToe**

6.1 Número de jugadores del juego

Dos jugadores.





6.2 Cómo se juega

**¿Cómo se juega? (pasos para jugarlo):**

Se juega de forma sencilla, con dos personas o de forma automática (o con la compu)

**¿Cómo ganar?**

Para ganar los competidores tienen que alinear “3X” o “3O” de forma horizontal, vertical

o diagonal en la izquierda o derecha.

6.3 Capturas de pantalla





