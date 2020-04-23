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
            <p>You have a total of {robsDogs.dogNames.length} dogs. They are:</p>
            <ul>
                {robsDogs.dogNames.map((dog) => (
                <li>{dog}</li>
                ))}
            </ul>
        </div>
    );
  }
}
