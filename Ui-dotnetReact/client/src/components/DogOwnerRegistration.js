import React, {useEffect, useState} from 'react'
import {
  Container,
  Row,
  Col,
  Form,
  Button,
  Modal
} from 'react-bootstrap'

import config from '../config.json'

const DogOwnerRegistration = ({onOpen}) => {
  const [ownerName, setOwnerName] = useState('')
  const [dogName, setDogName] = useState('')

  useEffect(() => {

  }, [])

  const handleSubmit = async (event) => {
    event.preventDefault()
    console.log(ownerName, dogName)
    const url = `${config.API_HOST}`

    const response = await fetch(url, {
      method: 'POST',
      mode: 'cors',
      headers: {
        'Content-Type': 'application/json',
        // 'Authorization': 'no-auth',
        // 'Accept': '*/*',
      },
      body: JSON.stringify({
        ownerName: ownerName,
        dogName: dogName
      })
    })

    console.log(response)

    onOpen(false)
  }

  return (
      <Modal.Dialog>
        <Modal.Header closeButton>
          <Modal.Title>Registration</Modal.Title>
        </Modal.Header>

        <Form>
          <Modal.Body>
            <Form.Group controlId="ownerName">
              <Form.Label>Owner Name</Form.Label>
              <Form.Control 
                type="text" 
                placeholder="Enter owner's name" 
                value={ownerName}
                onChange={(e) => setOwnerName(e.target.value)}
              />
              <Form.Text className="text-muted">
                We'll never share your name with anyone else.
              </Form.Text>
            </Form.Group>
            <Form.Group controlId="dogName">
              <Form.Label>Dog Name</Form.Label>
              <Form.Control 
                type="text" 
                placeholder="Enter your dogs' names" 
                value={dogName}
                onChange={(e) => setDogName(e.target.value)}
              />
            </Form.Group>
          </Modal.Body>
          <Modal.Footer>
            <Button variant="secondary" type="close" onClick={() => onOpen(false)}>
              Cancel
            </Button>
            <Button variant="primary" onClick={(e)=> handleSubmit(e)}>
              Submit
            </Button>
          </Modal.Footer>
        </Form>
      </Modal.Dialog>
      
  )
}

export default DogOwnerRegistration