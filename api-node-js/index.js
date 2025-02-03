const express = require('express');
const app = express();
const http = require('http');
const server = http.createServer(app);
const transactionsController = require('./transactionsController.js');

app.use(express.json());

app.get('/', (req, res) => {
    res.json({ message: '¡Hola Mundo!' })
});

app.post('/transactions', async (req, res) => {
    try {
        if (req.body.user_id == null){
            res.status(400).json({ error: 'Campo user_id no enviado' });
            return;
        }
        if (req.body.amount == null){
            res.status(400).json({ error: 'Campo amount no enviado' });
            return;
        }
        console.log(req.body);
        await transactionsController.createTransaction(req.body);
        res.status(201).json({ message: 'Registro exitoso' });
    } catch (error) {
        res.status(500).json({ error: 'Error al registrar la transacción' });
    }
});

app.get('/transactions', async (req, res) => {
    const data = await transactionsController.getTransactions();
    res.json(data);
});

app.get('/transactions/user/:userId', async (req, res) => {
    const { userId } = req.params;
    const data = await transactionsController.getTransactionByIdUser(userId);
    res.json(data);

});

server.listen(3000, () => {
    console.log('listening on *:3000');
});
