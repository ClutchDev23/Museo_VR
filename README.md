<h1 align="center">🏛️ Museo Virtual Coreano - Experiencia XR</h1>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-00FF00?style=for-the-badge&logo=unity&logoColor=black" alt="Unity" />
  <img src="https://img.shields.io/badge/C%23-00FF00?style=for-the-badge&logo=c-sharp&logoColor=black" alt="C#" />
  <img src="https://img.shields.io/badge/XR_Toolkit-00FF00?style=for-the-badge&logo=oculus&logoColor=black" alt="XR Toolkit" />
</p>

## 📖 Descripción del Proyecto
Simulador de realidad virtual interactivo ambientado en una sala de exhibición de estilo tradicional coreano (Hanok). El proyecto permite al usuario recorrer el entorno en primera persona y manipular reliquias históricas mediante mecánicas inmersivas de agarre.

## ✨ Características Principales
- **Interacción XR Avanzada:** Manipulación de objetos 3D (vasijas, teteras) mediante el sistema de físicas de `XR Grab Interactable`.
- **Estabilidad de Físicas:** Sistema de colisiones optimizado (`Box Collider` dinámicos sobre `Mesh Collider` estáticos) para evitar interpenetraciones y fuerzas no deseadas.
- **Auto-Retorno de Reliquias:** Implementación de un script personalizado en C# que detecta el evento `Select Exited` para teletransportar y estabilizar los objetos en sus pedestales originales al soltarlos.
- **Entorno Inmersivo:** Arquitectura interior con límites de colisión perimetrales, iluminación cálida de texturas PBR y sistema de audio espacial de fondo continuo.

## 🛠️ Tecnologías y Herramientas
- **Motor Gráfico:** Unity 3D
- **Lógica y Scripts:** C#
- **Realidad Virtual:** Paquetes XR Plugin Management y XR Interaction Toolkit
- **Pruebas:** XR Device Simulator (para testeo de mecánicas sin hardware VR externo)

## ⚙️ Estructura y Clonación
Para probar este proyecto en tu entorno local:
1. Clona este repositorio:
   ```bash
   git clone [https://github.com/tu-usuario/Museo-VR-Coreano.git](https://github.com/tu-usuario/Museo-VR-Coreano.git)
