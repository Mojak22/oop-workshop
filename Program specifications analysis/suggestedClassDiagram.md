```mermaid
classDiagram
    class Building
    class Floor
    class Room
    class Device
    class InputDevice
    class OutputDevice
    class Consumer
    class Sample
    class Process

    Building --> Floor
    Floor --> Room
    Room --> Device
    InputDevice --|> Device
    InputDevice --> Consumer
    OutputDevice --|> Device
    OutputDevice ..|> Consumer
    Consumer --> Sample
    Process ..|> Consumer
    Process --> Consumer
```