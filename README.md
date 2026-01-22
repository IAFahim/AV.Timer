# AV.Timer

[![Unity Version](https://img.shields.io/badge/Unity-2022.3%2B-blue.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE.md)
[![Version](https://img.shields.io/badge/Version-1.0.0-orange.svg)](CHANGELOG.md)

Timer and cooldown trigger components for Unity with UnityEvent integration.

## Features

- CooldownTrigger component for event-based cooldowns
- TimeTrigger for one-shot timer events
- UnityEvent integration for visual programming
- Automatic reset on enable
- Simple inspector configuration

## Installation

```
Window > Package Manager > + > Add package from git URL
```
```
https://github.com/IAFahim/AV.Timer.git
```

## Usage

```csharp
using AV.Timer.Runtime;

public class MyBehaviour : MonoBehaviour
{
    // Add CooldownTrigger component in Inspector
    // Configure cooldown duration and UnityEvent callbacks
}
```

Or add via Inspector and configure:
- Cooldown: Duration
- On Time Triggered: UnityEvent callback

## License

MIT License - see [LICENSE.md](LICENSE.md) for details.

## Author

**IAFahim** - [GitHub](https://github.com/IAFahim)
