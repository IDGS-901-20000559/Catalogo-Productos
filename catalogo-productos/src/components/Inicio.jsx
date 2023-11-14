import { useCallback, useEffect, useState } from "react";
import Productos from './Productos';
import { Link } from "react-router-dom";

const Inicio = () => {
    const [products, setProducts] = useState([]);

    // Consulta a la API para obtener todos los productos
    const getProducts = async () => {
        const url = 'https://localhost:7140/Products/GetAll';
        const resp = await fetch(url);
        const data = await resp.json();
        setProducts(data);
    };

    // Se utiliza useEffect para llamar a getProducts una vez que el componente se ha renderizado
    useEffect(() => {
        getProducts();
    }, []); 

	// La misma funcion para buscar productos pero usando el useCallBack
	const searchProduct = useCallback(async () => {
		const name = document.getElementById('txtBusqueda').value;
		if (name === '') {
			getProducts();
		}else{
		const api = await fetch(`https://localhost:7140/Products/search/${name}`);
		if (api.status === 404) {
			alert('No se encontraron productos con ese nombre');
			return;
		}else{
			const data = await api.json();
			setProducts(data);
		}
		}
		
	}, [setProducts]);
    
  return (
    <>
    <div id="container">
		<header id="header">
			<div className="inner">
			<Link to={`/`} style={{ textDecoration: 'none', color: 'inherit' }}>
					<a href="index.html" className="logo">
						<span className="symbol"><img src="src/images/maskable_icon.png" alt="" /></span>
						<span className="title">TecnoTienda | Productos</span>
					</a>
			</Link>
			</div>
		</header>
		<div id="main">
			<div className="inner">
				<header>
					<center>
					<h1>Bienvenido a TecnoTienda<br />
					Tu sitio de ventas de preferencia</h1>
					<br />
					<p>En TecnoTienda encontraras una inmensa cantidad de categorías de los mejores productos a los mejores precios.</p>
					</center>
				</header>
				<section className="search">
					<center>
					<input
						type="text"
						name="txtBusqueda"
						id="txtBusqueda"
						placeholder="Busca tus productos"
						style={{ width: "50%", textAlign: "center" }}
					/>
					<br />
					<button type="button" className="primary" onClick={searchProduct}>
						Buscar 🔍
					</button>
					</center>
				</section>
				<br/><br/>
				<Productos products={products} />
			</div>
		</div>

		<footer id="footer">
			<div className="inner">
				<section>
					<h2>Contactanos</h2>
					<form method="post" action="#">
						<div className="fields">
							<div className="field half">
								<input type="text" name="name" id="name" placeholder="Tu nombre" />
							</div>
							<div className="field half">
								<input type="email" name="email" id="email" placeholder="Correo" />
							</div>
							<div className="field">
								<textarea name="message" id="message" placeholder="Mensaje"></textarea>
							</div>
						</div>
						<ul className="actions">
							<li><input type="submit" value="Enviar comentarios" className="primary" /></li>
						</ul>
					</form>
				</section>
				<section>
					<h2>Siguenos</h2>
					<ul className="icons">
						<li><a href="#" className="icon brands style2 fa-twitter"><span className="label">Twitter</span></a></li>
						<li><a href="#" className="icon brands style2 fa-facebook-f"><span className="label">Facebook</span></a></li>
						<li><a href="#" className="icon brands style2 fa-instagram"><span className="label">Instagram</span></a></li>
						<li><a href="https://github.com/IDGS-901-20000559" className="icon brands style2 fa-github"><span className="label">GitHub</span></a></li>
						<li><a href="#" className="icon brands style2 fa-500px"><span className="label">500px</span></a></li>
						<li><a href="tel:4791377052" className="icon solid style2 fa-phone"><span className="label">Telefono</span></a></li>
						<li><a href="mailto:jonathan_yasim@hotmail.com" className="icon solid style2 fa-envelope"><span className="label">Email</span></a></li>
					</ul>
				</section>
				<ul className="copyright">
					<li>&copy; TecnoTienda. Todo los derechos reservados</li><li>Desarrollado por Jonathan Yasim Hernández López</li>
				</ul>
			</div>
		</footer>
	</div>
    </>
  )
}

export default Inicio