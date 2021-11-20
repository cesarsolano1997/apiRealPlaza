
# Real Plaza Prueba- WebApi .Net

Este es mi proyecto realizado con WebApi .Net para la prueba técnica del 2021.




## API Reference

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

