#### Тестовое задание персонаж

Персонаж (Character) вызывает события по движению, взаимодействию с объектами.               
Сам персонаж создается при помощи паттерна "Фасад" (CharacterFacade), также к нему подключаются необходимые модули через файл Config по шаблону CharacterConfig.                    Взаимодействие с объектами направляется в модули HealthPickModule, DamageModule, InterationUI.     
Модули срабатывают через триггеры. В них же идет обработчик событий (HandleInteract). 
