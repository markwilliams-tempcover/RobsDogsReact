import React, { Component } from 'react';

export class Dogs extends Component {
    displayName = Dogs.name;

    render() {
      const robsDogs = {
        ownerName: 'Rob',
        dogNames: ['Willow', 'Nook', 'Sox']
      };

    return (
        <div>
            <h1>Hello, {robsDogs.ownerName}!</h1>
        </div>
    );
  }
}
