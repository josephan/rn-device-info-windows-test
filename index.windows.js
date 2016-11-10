import React, { Component } from 'react';
import {
  AppRegistry,
  StyleSheet,
  Text,
  View
} from 'react-native';

import Device from 'react-native-device-info';
import PageOne from './components/PageOne';
import PageTwo from './components/PageTwo';

import {Scene, Router} from 'react-native-router-flux';

class AwesomeProject extends Component {
  render() {
    console.log('====================');
    console.log('Device Info: ', Device.getModel());
    console.log('====================');
    return (
      <Router>
        <Scene key="root">
          <Scene key="pageOne" component={PageOne} title="PageOne" initial={true} />
          <Scene key="pageTwo" component={PageTwo} title="PageTwo" />
        </Scene>
      </Router>
    );
  }
}

const styles = StyleSheet.create({

});

AppRegistry.registerComponent('AwesomeProject', () => AwesomeProject);
