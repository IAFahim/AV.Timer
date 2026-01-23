# AV.Timer

![Header](documentation_header.svg)

[![Unity](https://img.shields.io/badge/Unity-2022.3%2B-000000.svg?style=flat-square&logo=unity)](https://unity.com)
[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square)](LICENSE.md)

UnityEvent wrappers for `Variable.Timer` structs.

## ✨ Features

- **CooldownTrigger**: Ticks a cooldown every frame and fires a UnityEvent when ready.
- **Zero Allocation Logic**: Wraps the allocation-free `Variable.Timer` structs.

## 📦 Installation

Install via Unity Package Manager (git URL).

### Dependencies
- **Variable.Timer** (NuGet)

## 🚀 Usage

1. Add `CooldownTrigger` to a GameObject.
2. Set `Duration`.
3. Connect `OnTimeTriggered` to your logic (e.g., `SpawnEnemy`).

## ⚠️ Status

- 🧪 **Tests**: Missing.
- 📘 **Samples**: None.
