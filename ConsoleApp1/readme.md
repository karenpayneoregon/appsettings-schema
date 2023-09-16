# About

These are non appsettings.json but could be helpful.

Example where a property must start with A-Z/a-z with three numbers following the letter

```json
"Code": {
  "type": "string",
  "description": "Auto-generated code",
  "pattern": "^[A-Z][0-9]{3}$",
  "default": "A000"
}
```

Example to min and max length and value can not contain A-Z/a-z.

```json
"CompanyName": {
  "type": "string",
  "minLength": 3,
  "maxLength": 100,
  "pattern": "^[A-Za-z\\s]*$",
  "description": "Company letters only",
  "title": "Company name"
}
```
