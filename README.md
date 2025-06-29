# Система оренди квартир

## 1. Назва застосунку
EasyFlat – зручна онлайн-платформа для пошуку та бронювання квартир.

## 2. Мета
Забезпечити зручний та ефективний сервіс для пошуку, оренди та управління квартирами. Платформа допомагає орендодавцям знаходити орендарів, а користувачам – швидко знаходити житло відповідно до своїх потреб.

## 3. Користувачі та їх можливості
Орендодавець (Власник квартири)
- Реєстрація та авторизація.
- Додавання оголошень про оренду квартир.
- Редагування та видалення власних оголошень.
- Перегляд заявок від потенційних орендарів.

Орендар (Користувач, який шукає квартиру)
- Реєстрація та авторизація.
- Перегляд списку доступних квартир.
- Фільтрація за ціною, місцем розташування, площею, кількістю кімнат.

## 4. Основні сутності  (основні об'єкти, якими оперує застосунок, та їх поля)

#### 1. Користувач (User)
- ID
- Ім'я
- Email
- Номер телефону
- Тип користувача (Орендар/Орендодавець)

#### 2. Оголошення (Listing)
- ID
- Назва
- Опис
- Локація
- Ціна оренди
- Кількість кімнат
- Площа
- ID власника
- Дата публікації


## 5. Можливості застосунку
- Реєстрація та авторизація користувачів. 
- Додавання та редагування оголошень. 
- Модерація контенту власником сайту.
- Фільтрація квартир за параметрами.

## 5. Вибір технології UI. 
WinForms; SQL
