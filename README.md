
# Real Plaza Prueba- WebApi .Net

Este es mi proyecto realizado con WebApi .Net para la prueba técnica del 2021.




## API Reference

### Obtener token de verificación de usuario
```http
  POST /api/token/generate
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Name`      | `string` | **Required**. Nombre del usuario |
| `Email`     | `string` | **Required**. Email del usuario |

Esto te generará un token que servirá para poder obtener la información 
del api, irá en los `Headers` de todas las peticiones como un `Bearer ${token}`


#### Obtener todos los centro comerciales

```http
  GET /api/mall/listMall
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |


#### Obtener lista de tiendas

```http
  GET /api/shops/listShops/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id de la mall |

#### Obtener lista de productos

```http
  GET /api/product/listProduct/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id de la tienda |

