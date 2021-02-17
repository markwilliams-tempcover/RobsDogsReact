import React, {useEffect, useState} from 'react'
import {
  Container,
  Row,
  Col,
  Form,
  Button,
  Modal,
  ListGroup
} from 'react-bootstrap'

import config from '../config.json'

const styles = {
  tableCell: {
    width: '25%'
  },
}

const DogOwnerSearch = () => {
  const [ownerId, setOwnerId] = useState('')
  const [ownerName, setOwnerName] = useState('')
  const [dogName, setDogName] = useState('')

  useEffect(() => {

  }, [])

  const handleSearch = async (event) => {
    console.log(ownerId)
    const url = `${config.API_HOST}/${ownerId}`

    const response = await fetch(url, {
      method: 'GET',
      mode: 'cors',
      headers: {
        'Content-Type': 'applicaton/json',
        // 'Authorization': 'no-auth',
        // 'Accept': '*/*',
        // 'proxy': 'http://localhost:3000'
      },
    })

    console.log(response)
    const json = await response.json()
    console.log(json)
    setOwnerId(json.id)
    setOwnerName(json.ownerName)
    setDogName(json.dogName)
  }

  return (
    <>
      <hr />
      <Form.Group as={Row} controlId="ownerId">
        <Form.Label column md="2" sm="2" xs="3">Owner ID</Form.Label>
        <Col md="5" sm="5" xs="4">
          <Form.Control 
            type="text" 
            placeholder="Enter owner's Id"
            value={ownerId}
            onChange={(e) => setOwnerId(e.target.value)}
          />
        </Col>
        <Col md="2" sm="2" xs="3">
          <Button variant="primary" onClick={() => handleSearch(ownerId)}>
            Search
          </Button>
        </Col>
      </Form.Group>

      <hr />

      <ListGroup horizontal>
        <ListGroup.Item variant="primary" style={styles.tableCell}>ID</ListGroup.Item>
        <ListGroup.Item style={styles.tableCell}>Owner Name</ListGroup.Item>
        <ListGroup.Item style={styles.tableCell}>Dog's Name</ListGroup.Item>
        <ListGroup.Item style={styles.tableCell}>Note</ListGroup.Item>
      </ListGroup>
      <ListGroup horizontal>
        <ListGroup.Item variant="primary" style={styles.tableCell}>{ownerId}</ListGroup.Item>
        <ListGroup.Item style={styles.tableCell}>{ownerName}</ListGroup.Item>
        <ListGroup.Item style={styles.tableCell}>{dogName}</ListGroup.Item>
        <ListGroup.Item style={styles.tableCell}></ListGroup.Item>
      </ListGroup>
    </>
  )
}

export default DogOwnerSearch