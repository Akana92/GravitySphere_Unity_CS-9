# Unity Assignment Project

## Overview

This Unity project consists of three distinct tasks aimed at demonstrating various Unity features and functionalities. The project is organized into separate scenes, each focusing on specific aspects of Unity development such as collision handling, physics interactions, and trigger zones.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
  - [1. Superman Script and Layers](#1-superman-script-and-layers)
  - [2. Billiard Table Simulation](#2-billiard-table-simulation)
  - [3. Zero Gravity Sphere](#3-zero-gravity-sphere)

## Features

### 1. Superman Script and Layers

- **Objective**: Implement a Superman character that interacts with other objects based on predefined layers.
- **Functionality**:
  - Superman passes through objects on the `GoodBoy` layer without collision.
  - Superman collides and applies force to objects on the `BadGuy` layer.
- **Key Components**:
  - `Superman.cs`: Script handling collision detection and force application.
  - Layer setup: `Superman`, `GoodBoy`, `BadGuy` layers with collision matrix configured.

### 2. Billiard Table Simulation

- **Objective**: Create a scene simulating a billiard table with pockets and ball interactions.
- **Functionality**:
  - Billiard table with pockets positioned at corners and midpoints of longer sides.
  - Cue ball launched with an impulse, causing interactions with other balls.
  - Balls fall into pockets upon collision.
- **Key Components**:
  - `CueBallController.cs`: Script to launch the cue ball with an impulse.
  - Physics materials for realistic ball interactions.
  - Pockets with trigger colliders to detect ball entry.

### 3. Zero Gravity Sphere

- **Objective**: Implement a zero-gravity zone that affects objects entering its boundary.
- **Functionality**:
  - A transparent sphere acting as a trigger zone to disable gravity on objects within.
  - Objects regain gravity upon exiting the zone.
  - A pipe constructed with colliders containing objects of varying mass and materials.
  - Explosion effect within the pipe interacting with objects.
- **Key Components**:
  - `ZeroGravityZone.cs`: Script to toggle gravity on entering/exiting the sphere.
  - `PipeBuilder.cs`: Script to construct the pipe with visual and collision elements.
  - `Explosion.cs`: Script to simulate an explosion affecting objects within the pipe.

---

## Русская Версия

```markdown
# Проект задания Unity

## Обзор

Этот проект Unity состоит из трёх отдельных задач, направленных на демонстрацию различных возможностей и функционала Unity. Проект организован в виде отдельных сцен, каждая из которых фокусируется на конкретных аспектах разработки на Unity, таких как обработка столкновений, взаимодействие с физикой и зоны триггеров.

## Содержание

- [Обзор](#обзор)
- [Особенности](#особенности)
  - [1. Скрипт Superman и слои](#1-скрипт-superman-и-слои)
  - [2. Имитация бильярдного стола](#2-имитация-бильярдного-стола)
  - [3. Сфера невесомости](#3-сфера-невесомости)

## Особенности

### 1. Скрипт Superman и слои

- **Цель**: Реализовать персонажа Супермена, который взаимодействует с другими объектами на основе предопределённых слоёв.
- **Функциональность**:
  - Супермен проходит сквозь объекты на слое `GoodBoy` без столкновений.
  - Супермен сталкивается и применяет силу к объектам на слое `BadGuy`.
- **Ключевые компоненты**:
  - `Superman.cs`: Скрипт, обрабатывающий обнаружение столкновений и применение силы.
  - Настройка слоёв: слои `Superman`, `GoodBoy`, `BadGuy` с соответствующей матрицей столкновений.

### 2. Имитация бильярдного стола

- **Цель**: Создать сцену, имитирующую бильярдный стол с лунками и взаимодействиями между шарами.
- **Функциональность**:
  - Бильярдный стол с лунками, расположенными в углах и серединах длинных сторон.
  - Запуск битка с импульсом, вызывающий взаимодействия с другими шарами.
  - Шары падают в лунки при столкновениях.
- **Ключевые компоненты**:
  - `CueBallController.cs`: Скрипт для запуска битка с импульсом.
  - Физические материалы для реалистичного взаимодействия шаров.
  - Лунки с триггерными коллайдерами для обнаружения попадания шаров.

### 3. Сфера невесомости

- **Цель**: Реализовать зону невесомости, влияющую на объекты, входящие в её границы.
- **Функциональность**:
  - Полупрозрачная сфера, функционирующая как триггерная зона для отключения гравитации объектов внутри.
  - Объекты восстанавливают гравитацию при выходе из зоны.
  - Труба, составленная из коллайдеров, содержащая объекты с различной массой и материалами.
  - Эффект взрыва внутри трубы, взаимодействующий с объектами.
- **Ключевые компоненты**:
  - `ZeroGravityZone.cs`: Скрипт для переключения гравитации при входе/выходе из сферы.
  - `PipeBuilder.cs`: Скрипт для построения трубы с визуальными и коллизионными элементами.
  - `Explosion.cs`: Скрипт для симуляции взрыва, влияющего на объекты внутри трубы.
```
