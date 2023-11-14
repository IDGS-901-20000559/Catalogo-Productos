import { useEffect, useState } from 'react';
import { Link, useParams } from 'react-router-dom';

const ProductDetail = ( ) => {
    const idProduct = useParams().id;
    const [producto, setProduct] = useState([]);

    const getProduct = async () => {
        const url = `https://localhost:7140/Products/Get/${idProduct}`;
        const resp = await fetch(url);
        const data = await resp.json();
        getRating(data.rating);
        setProduct(data);
    };

    useEffect(() => {
        getProduct();
    }, [idProduct]);

    // Función para evaluar la calificación del producto
    // La calificación de la base de datos se encuentra con puntos decimales por lo que
    // se redondea al entero más cercano
    const getRating = (rating) => {
        const ratingElement = document.getElementById('rating');
        ratingElement.innerHTML = '';
        const ratingNumber = Math.round(rating);
        for (let i = 0; i < ratingNumber; i++) {
            const star = document.createElement('i');
            star.setAttribute('class', 'fa fa-star');
            ratingElement.appendChild(star);
        }
        for (let i = 0; i < 5 - ratingNumber; i++) {
            const star = document.createElement('i');
            star.setAttribute('class', 'fa fa-star-o');
            ratingElement.appendChild(star);
        }
    };
   
    return (
        <>
        <div id="container">
		<header id="header">
			<div className="inner">
			<Link to={`/`} style={{ textDecoration: 'none', color: 'inherit' }}>
					<a href="index.html" className="logo">
                    <span className="symbol"><img src="https://cdn-icons-png.flaticon.com/512/17/17699.png" alt="" /></span>
						<span className="title">Regresar al catalogo</span>
					</a>
			</Link>
			</div>
		</header>
            <div id="main">
                <div className="inner">
                    <center>
                        <h1>{producto.nombre}</h1>
                    </center>
                    <center>
                        <div style={{width:"50%"}}>
                            <img src={producto.imagen} alt="" width={700} />
                        </div>
                    </center>
                    <center>
                        <h2>{producto.descripcion}</h2>
                        <br />
                        <h4>De ${(producto.precio / (1 - producto.descuentoPorcentaje / 100)).toFixed(2)} a solo <span style={{color:"#56E30F"}}>${producto.precio}</span></h4>
                    </center>

                    <p>
                        <b>Marca : </b> {producto.marca}
                    </p>
                    <p>{producto.stock} pz(s) en existencia</p>
                    <p>
                        <b>Categoria : </b> {producto.categoria}
                    </p>
                    <p>
                        <b>Descuento : </b> {producto.descuentoPorcentaje}%
                    </p>
                    <p>
                        <b>Calificacion : </b><p id='rating' className='text-warning'></p>
                    </p>
                    <center>
                        <button
                            className="primary"
                            style={{
                                backgroundColor: '#56E30F',
                                color: '#FFF',
                                padding: '10px',
                                borderRadius: '5px',
                            }}
                        >
                            <i className="fa fa-shopping-bag" style={{ marginRight: '5px' }}></i> Comprar
                        </button>
                    </center>
                </div>
            </div>
            </div>
        </>
    );
};

export default ProductDetail;
